using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Canvas
{
    public partial class Main : MaterialForm
    {
        Dictionary<string, string> dict = new Dictionary<string, string>();

        List<long> list = new List<long>();

        public static string score;

        public static bool locked = true;

        public static string token;

        public Main()
        {
            var portal = new Portal();
            portal.ShowDialog();
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
            loadDict();
            var Wc = new WebClient();
            try
            {
                var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/users/self/enrollments?access_token=" + token);
                dynamic json = JsonConvert.DeserializeObject(res);
                foreach (JObject result in json)
                {
                    foreach (JProperty property in result.Properties())
                    {
                        if (property.ToString().Contains("name"))
                        {
                            materialLabel1.Text = "User Name: " + property.Value["name"].ToString();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid token or Canvas API is offline!");
                Environment.Exit(1);
            }

            listView1.View = View.Details;

            listView1.GridLines = true;

            listView1.FullRowSelect = true;

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Add column header

            // listview2
            listView2.View = View.Details;

            listView2.GridLines = true;

            listView2.FullRowSelect = true;

            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        public static void updateToken(string token2) => token = token2;

        public void incorrect()
        {
            MessageBox.Show("Incorrect login.");
            return;
        }

        public string getScore(string course_id, string id)
        {
            try
            {
                var Wc = new WebClient();
                var res2 = Wc.DownloadString("https://canvas.instructure.com/api/v1/courses/" + course_id + "/assignments/" + id + "/submissions/self" + "?per_page=50&access_token=" + token);
                dynamic json2 = JsonConvert.DeserializeObject(res2);
                foreach (JProperty property in json2.Properties())
                {
                    if (property.Name == "score")
                    {
                        score = property.Value.ToString();
                    }
                }
            }
            catch
            {
                return "";
            }

            return score;
        }

        public int periodID()
        {
            var Wc = new WebClient();
            foreach (KeyValuePair<string, string> entry in dict)
            {
                var course_id = entry.Value;
                var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/courses/" + course_id + "/grading_periods?access_token=" + token);
                dynamic data = JObject.Parse(res);
                MessageBox.Show(data.ToString());
                // retrieve champion objects
                JToken champions = data["grading_periods"];

                // retrieve the champion desired object using the Linq FirstOrDefault method. 
                // This method will return the first object that matches the given query,
                // or return null if it does not find a match.
                var champion = champions.FirstOrDefault(c => (string)c["title"] == "Term 2");

                if (champion != null)
                {
                    // retrieve the stats object
                    var id = champion["id"];
                    // MessageBox.Show(champion.ToString());
                    list.Add((long)id);
                }
            }

            return 0;
        }

        public static string StripHTML(string input)
        {
            if (input == null)
            {
                return "";
            }

            return Regex.Replace(input, "<.*?>", string.Empty);
        }

        public void loadDict()
        {
            var Wc = new WebClient();
            try
            {
                var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/courses?access_token=" + token);
                dynamic json = JsonConvert.DeserializeObject(res);
                foreach (JObject result in json)
                {
                    var name = result.GetValue("name").Value<string>();
                    var id = result.GetValue("id").Value<string>();
                    try
                    {
                        dict.Add(name, id);
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid token or Canvis API is down!");
                Environment.Exit(1);
            }
        }

        void Main_Load(object sender, EventArgs e)
        {
        }

        void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                var Wc = new WebClient();
                var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/courses?access_token=" + token);
                dynamic json = JsonConvert.DeserializeObject(res);
                foreach (JObject result in json)
                {
                    var name = result.GetValue("name").Value<string>();
                    var id = result.GetValue("id").Value<string>();
                    listBox1.Items.Add(name);
                }
            }
            else
            {
                MessageBox.Show("Courses already loaded!");
            }
        }

        void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count != 0)
            {
                MessageBox.Show("Grades already loaded!");
                return;
            }

            var Wc = new WebClient();
            var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/users/self/enrollments?grading_period_id=95220000000000010&access_token=" + token);
            dynamic json = JsonConvert.DeserializeObject(res);
            // MessageBox.Show(json.ToString());
            foreach (JObject result in json)
            {
                var id = result.GetValue("course_id").Value<string>();
                var name = dict.FirstOrDefault(x => x.Value == id).Key;
                foreach (JProperty property in result.Properties())
                {
                    if (property.ToString().Contains("current_score"))
                    {
                        if (property.Value["current_score"].ToString() != "")
                        {
                            listBox2.Items.Add(property.Value["current_score"].ToString() + " | " + property.Value["current_grade"].ToString() + " | " + name);
                        }
                    }
                }
            }

            var res2 = Wc.DownloadString("https://canvas.instructure.com/api/v1/users/self/enrollments?grading_period_id=95220000000000016&access_token=" + token);
            dynamic json2 = JsonConvert.DeserializeObject(res2);
            // MessageBox.Show(json2.ToString());
            foreach (JObject result in json2)
            {
                var id = result.GetValue("course_id").Value<string>();
                var name = dict.FirstOrDefault(x => x.Value == id).Key;
                foreach (JProperty property in result.Properties())
                {
                    if (property.ToString().Contains("current_score"))
                    {
                        if (property.Value["current_score"].ToString() != "")
                        {
                            listBox2.Items.Add(property.Value["current_score"].ToString() + " | " + property.Value["current_grade"].ToString() + " | " + name);
                        }
                    }
                }
            }
        }

        void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listView1.Items.Clear();
            var course_id = dict.FirstOrDefault(x => x.Key == listBox1.SelectedItem.ToString()).Value;
            // Clipboard.SetText(course_id);
            var course_name = dict.FirstOrDefault(x => x.Value == course_id).Key;
            var Wc = new WebClient();
            var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/courses/" + course_id + "/assignments?per_page=1000&access_token=" + token);
            dynamic json = JsonConvert.DeserializeObject(res);
            materialLabel2.Text = "Current Course: " + course_name;
            materialTabControl1.SelectedIndex = 1;
            // MessageBox.Show(json.ToString());
            foreach (JObject result in json)
            {
                foreach (JProperty property in result.Properties())
                {
                    if (property.Name == "name")
                    {
                        var assign_id = result.GetValue("id").Value<string>();
                        if (materialCheckBox1.Checked)
                        {
                            score = getScore(course_id, assign_id);
                        }

                        var name = result.GetValue("name").Value<string>();
                        var points = result.GetValue("points_possible").Value<string>();
                        var due = result.GetValue("due_at").Value<string>();
                        var desc = result.GetValue("description").Value<string>();
                        string[] arr = new string[5];
                        ListViewItem itm;
                        // add items to ListView
                        arr[0] = name;
                        arr[1] = score;
                        arr[2] = points;
                        arr[3] = due;
                        if (desc != "")
                        {
                            var done = StripHTML(desc);
                            arr[4] = done;
                        }

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                }
            }
        }

        void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red800, Primary.Red900, Primary.Red500, Accent.Red200, TextShade.WHITE);
        }

        void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow200, TextShade.WHITE);
        }

        void materialRaisedButton13_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo800, Primary.Indigo900, Primary.Indigo500, Accent.Indigo200, TextShade.WHITE);
        }

        void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Pink800, Primary.Pink900, Primary.Pink500, Accent.Pink200, TextShade.WHITE);
        }

        void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.Purple900, Primary.Purple500, Accent.Purple200, TextShade.WHITE);
        }

        void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal800, Primary.Teal900, Primary.Teal500, Accent.Teal200, TextShade.WHITE);
        }

        void materialRaisedButton15_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
        }

        void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listView1.Items[listView1.FocusedItem.Index].Text;

            checkedListBox1.Items.Add(item);

            materialTabControl1.SelectedIndex = 0;
        }

        void materialTabSelector1_Click(object sender, EventArgs e)
        {
        }

        void checkedListBox1_DoubleClick(object sender, EventArgs e)
        {
            checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
        }

        void materialRaisedButton16_Click(object sender, EventArgs e)
        {
            if (listView2.Items.Count == 0)
            {
                var Wc = new WebClient();
                var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/users/self/todo?access_token=" + token);
                dynamic json = JsonConvert.DeserializeObject(res);
                // MessageBox.Show(json.ToString());
                foreach (JObject result in json)
                {
                    // MessageBox.Show(result["assignment"].ToString());
                    var name = result["assignment"]["name"].ToString();
                    var description = result["assignment"]["description"].ToString();
                    var due = result["assignment"]["due_at"].ToString();
                    string[] arr2 = new string[5];
                    ListViewItem itm;
                    arr2[0] = name;
                    arr2[1] = StripHTML(description);
                    arr2[2] = due;
                    itm = new ListViewItem(arr2);
                    listView2.Items.Add(itm);
                }
            }
            else
            {
                MessageBox.Show("You've already loaded the calendar!");
            }
        }

        void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void listView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var sortColumn = 2;
            // Determine whether the column is the same as the last column clicked.  
            if (e.Column != sortColumn)
            {
            }
            else
            {
                // Determine what the last sort order was and change it.  
                if (listView2.Sorting == SortOrder.Ascending)
                    listView2.Sorting = SortOrder.Descending;
                else
                    listView2.Sorting = SortOrder.Ascending;
                // Call the sort method to manually sort.  
                listView2.Sort();
                // Set the ListViewItemSorter property to a new ListViewItemComparer  
                // object.  
                listView2.ListViewItemSorter = new Functions.ListViewItemComparer(e.Column,
                                                                  listView2.Sorting);
            }
        }

        void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
        }

        void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = listView2.Items[listView2.FocusedItem.Index].Text;

            checkedListBox1.Items.Add(item);

            materialTabControl1.SelectedIndex = 0;
        }

        void materialRaisedButton17_Click(object sender, EventArgs e)
        {
            var Wc = new WebClient();
            var res = Wc.DownloadString("https://canvas.instructure.com/api/v1/calendar_events?all_events=1&access_token=" + token);
            // dynamic json = JsonConvert.DeserializeObject(res);
            MessageBox.Show(res.ToString());
            // MessageBox.Show(json.ToString());
        }
    }
}