using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeeSharpTimer
{
    public partial class Timer : Form
    {
        //public Timer()
        //{
        //    InitializeComponent();
        //}

            public class GlobalVariables
            {

                public static string projects;

                public static string iniFile;

                public static string CurrentTime;

                public static string CurrentProject;
            }

            private void Timer_Load(object sender, EventArgs e)
            {
                GlobalVariables.iniFile = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Timer.ini");
                GlobalVariables.projects = ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "Projects", "list");
                HistoryBox.Text = (HistoryBox.Text + ("Please Selected a project." + Environment.NewLine));
                HistoryBox.Text = (HistoryBox.Text + ("Available projects: "
                            + (GlobalVariables.projects + Environment.NewLine)));
                this.PopulateComboBox();
            }

            void PopulateComboBox()
            {
                ProjectSelector.Items.Add("Please Select");
                ProjectSelector.SelectedItem = "Please Select";
                int amountOfProjects;
                amountOfProjects = (this.FindWords(GlobalVariables.projects, ",") - 1);
            int i;
                for (i = amountOfProjects; (i <= 0); i = (i + -1))
                {
                    string[] availableProjects = GlobalVariables.projects.Split(new char[] {
                        ",",
                        c});
                    ProjectSelector.Items.Add(availableProjects[i]);
                }

            }

            private int FindWords(string TextSearched, string Paragraph)
            {
                int location = 0;
                int occurances = 0;
                for (
                ; ((location == -1)
                            == false);
                )
                {
                    location = TextSearched.IndexOf(Paragraph, location);
                    if ((location != -1))
                    {
                        occurances++;
                        location = (location + Paragraph.Length);
                    }

                }

                return occurances;
            }

            private void ProjectTimer_Tick(object sender, EventArgs e)
            {
                if ((ProjectSelector.SelectedItem.ToString() == "Please Select"))
                {
                    StartStop.Enabled = false;
                    DeleteProject.Enabled = false;
                    NewProject.Enabled = true;
                }
                else
                {
                    StartStop.Enabled = true;
                    DeleteProject.Enabled = true;
                    NewProject.Enabled = false;
                }

            }

            private void StartStop_Click(object sender, EventArgs e)
            {
                DateTime moment = DateTime.Now;
                if ((StartStop.Text == "Start timer"))
                {
                    DayTimer.Enabled = true;
                    HourTimer.Enabled = true;
                    MinuteTimer.Enabled = true;
                    SecondTimer.Enabled = true;
                    HistoryBox.Text = (HistoryBox.Text + ("START: "
                                + (moment.ToString() + Environment.NewLine)));
                }
                else
                {
                    DayTimer.Enabled = false;
                    HourTimer.Enabled = false;
                    MinuteTimer.Enabled = false;
                    SecondTimer.Enabled = false;
                    HistoryBox.Text = (HistoryBox.Text + ("STOP: "
                                + (moment.ToString() + Environment.NewLine)));
                    ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "Times", GlobalVariables.CurrentProject, (Days.Text + (","
                                    + (Hours.Text + (","
                                    + (Minutes.Text + ("," + Seconds.Text)))))));
                    string History;
                    History = HistoryBox.Text.Replace(Environment.NewLine, ",").ToString();
                    ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject, History.Replace(("Selected Project: "
                                        + (GlobalVariables.CurrentProject + ",,")), ""));
                }

                if ((StartStop.Text == "Start timer"))
                {
                    StartStop.Text = "Stop timer";
                }
                else
                {
                    StartStop.Text = "Start timer";
                }

            }

            private void ProjectSelector_SelectedValueChanged(object sender, EventArgs e)
            {
                GlobalVariables.CurrentProject = ProjectSelector.SelectedItem.ToString();
                if ((ProjectSelector.SelectedItem.ToString() == "Please Select"))
                {
                    HistoryBox.Text = "Please select or create a Project.";
                    Days.Text = "0";
                    Hours.Text = "0";
                    Minutes.Text = "0";
                }
                else
                {
                    GlobalVariables.CurrentTime = ReadAndWriteIni.ReadIni((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Timer.ini"), "Times", GlobalVariables.CurrentProject);
                    string[] times = GlobalVariables.CurrentTime.Split(new char[] {
                        ",",
                        c});
                    Days.Text = times[0];
                    Hours.Text = times[1];
                    Minutes.Text = times[2];
                    Seconds.Text = times[3];
                    HistoryBox.Text = ("Selected Project: "
                                + (GlobalVariables.CurrentProject
                                + (Environment.NewLine + Environment.NewLine)));
                    this.GetHistory();
                }

            }

            private void GetHistory()
            {
                int amountOfHistoryEntries;
                amountOfHistoryEntries = (this.FindWords(ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject), ",") - 1);
                string[] Entries = null;
                for (i = amountOfHistoryEntries; (i <= 0); i = (i + -1))
                {
                    Entries = ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "History", GlobalVariables.CurrentProject).Split(new char[] {
                        ",",
                        c });
                }

                if (!(Entries == null))
                {
                    for (i = 0; (i
                                <= (Entries.Length - 2)); i++)
                    {
                        HistoryBox.Text = (HistoryBox.Text
                                    + (Entries[i] + Environment.NewLine));
                    }

                }

            }

            private void MinuteTimer_Tick(object sender, EventArgs e)
            {
                if ((Seconds.Text == "60"))
                {
                    Seconds.Text = "0";
                int x = Int32.Parse(Minutes.Text);
                Minutes.Text = x++.ToString();
                }

            }

            private void HourTimer_Tick(object sender, EventArgs e)
            {
                if ((Minutes.Text == "60"))
                {
                    Minutes.Text = "0";
                int x = Int32.Parse(Hours.Text);
                Hours.Text = x++.ToString();
                }

            }

            private void DayTimer_Tick(object sender, EventArgs e)
            {
                if ((Hours.Text == "60"))

                {
                    Hours.Text = "0";
                int x = Int32.Parse(Days.Text);
                Days.Text = x++.ToString();
                }

            }

            private void NewProject_Click(object sender, EventArgs e)
            {
            Retry:
                string NewProjectName = Microsoft.VisualBasic.Interaction.InputBox("Enter project name:", "New Project", "ProjectName");
                if (((NewProjectName.IndexOf(" ") + 1)
                            > 0))
                {
                Microsoft.VisualBasic.Interaction.MsgBox("That project name included spaces. Please use only alphanumerical characters.");
                    goto Retry;
                }

                string currentProjectsInIni = ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "Projects", "list");
                if (((currentProjectsInIni.IndexOf("ERROR:") + 1)
                            > 0))
                {
                    currentProjectsInIni = "";
                }

                ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "Projects", "list", (currentProjectsInIni
                                + (NewProjectName + ",")));
                ProjectSelector.Items.Clear();
                GlobalVariables.projects = ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "Projects", "list");
                this.PopulateComboBox();
                ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "Times", NewProjectName, "0,0,0,0");
                ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "History", NewProjectName, "");
            }

            private void DeleteProject_Click(object sender, EventArgs e)
            {
                string toBeDeleted = ProjectSelector.SelectedItem.ToString();
                string projectsNow = GlobalVariables.projects.Replace((toBeDeleted + ","), "");
                ReadAndWriteIni.writeIni(GlobalVariables.iniFile, "Projects", "list", projectsNow);
                WriteIni.deleteKeyFromIni(GlobalVariables.iniFile, "Times", toBeDeleted);
                WriteIni.deleteKeyFromIni(GlobalVariables.iniFile, "History", toBeDeleted);
                ProjectSelector.Items.Clear();
                GlobalVariables.projects = ReadAndWriteIni.ReadIni(GlobalVariables.iniFile, "Projects", "list");
                this.PopulateComboBox();
            }

            private void SecondTimer_Tick(object sender, EventArgs e)
            {
            int x = Int32.Parse(Seconds.Text);
                Seconds.Text = x++.ToString();
            }
        
    }
}
