using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Better_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            this.runningSortedBy.SelectedIndexChanged +=
            new System.EventHandler(runningSortedBy_SelectedIndexChanged);

            this.runningList.SelectedIndexChanged +=
            new System.EventHandler(runningList_SelectedIndexChanged);

            this.stoppedSortedBy.SelectedIndexChanged +=
            new System.EventHandler(stoppedSortedBy_SelectedIndexChanged);

            this.stoppedList.SelectedIndexChanged +=
           new System.EventHandler(stoppedList_SelectedIndexChanged);


        }
        

        private void Form1_Load(object sender, EventArgs e)
        {


            // Alle Dienste im System abrufen
            ServiceController[] dienste = ServiceController.GetServices();

            Console.WriteLine("Laufende Dienste:");
            foreach (ServiceController dienst in dienste)
            {
                // Nur laufende Dienste anzeigen
                if (dienst.Status == ServiceControllerStatus.Running)
                {
                    runningList.Items.Add(dienst.DisplayName);
                }
                else if (dienst.Status == ServiceControllerStatus.Stopped)
                {
                    stoppedList.Items.Add(dienst.DisplayName);
                }
            }
        }


        private void runningSortedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Liste leeren, sonst werden die Einträge immer wieder angehängt
            runningList.Items.Clear();

            ServiceController[] services = ServiceController.GetServices();


            if (runningSortedBy.SelectedIndex == 0)
            {
                // Alle Dienste im System abrufen
                ServiceController[] dienste = ServiceController.GetServices();

                Console.WriteLine("Laufende Dienste:");
                foreach (ServiceController dienst in dienste)
                {
                    if (dienst.Status == ServiceControllerStatus.Running) { runningList.Items.Add(dienst.DisplayName); }
                }
             }
            else if (runningSortedBy.SelectedIndex == 1)
            {
                // Sortieren nach DisplayName (alphabetisch)
                var ascendingServices = services.OrderBy(d => d.DisplayName);

                foreach (var dienst in ascendingServices)
                {
                    if (dienst.Status == ServiceControllerStatus.Running) { runningList.Items.Add(dienst.DisplayName); }
                }
            }
            else if (runningSortedBy.SelectedIndex == 2)
            {
                var descendingServices = services.OrderByDescending(d => d.DisplayName);

                foreach (var dienst in descendingServices)
                {
                    if (dienst.Status == ServiceControllerStatus.Running) { runningList.Items.Add(dienst.DisplayName); }
                }
            }
        }

        private void runningList_SelectedIndexChanged(object sender, EventArgs e)
        {
            stopServiceBtn.Enabled = true;
            restartBtn.Enabled = true;
        }

        private void stoppedList_SelectedIndexChanged(object sender, EventArgs e)
        {
            startServiceBtn.Enabled = true;

        }

        private void stoppedSortedBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Liste leeren, sonst werden die Einträge immer wieder angehängt
            stoppedList.Items.Clear();

            ServiceController[] services = ServiceController.GetServices();


            if (stoppedSortedBy.SelectedIndex == 0)
            {
                // Alle Dienste im System abrufen
                ServiceController[] dienste = ServiceController.GetServices();

                Console.WriteLine("Laufende Dienste:");
                foreach (ServiceController dienst in dienste)
                {
                    if(dienst.Status == ServiceControllerStatus.Stopped) { stoppedList.Items.Add(dienst.DisplayName); }
                    
                }
            }
            else if (stoppedSortedBy.SelectedIndex == 1)
            {
                // Sortieren nach DisplayName (alphabetisch)
                var ascendingServices = services.OrderBy(d => d.DisplayName);

                foreach (var dienst in ascendingServices)
                {
                    if (dienst.Status == ServiceControllerStatus.Stopped) { stoppedList.Items.Add(dienst.DisplayName); }
                }
            }
            else if (stoppedSortedBy.SelectedIndex == 2)
            {
                var descendingServices = services.OrderByDescending(d => d.DisplayName);

                foreach (var dienst in descendingServices)
                {
                    if (dienst.Status == ServiceControllerStatus.Stopped) { stoppedList.Items.Add(dienst.DisplayName); }
                }
            }
        }

        private void stopServiceBtn_Click(object sender, EventArgs e)
        {
            string selectedItem = runningList.SelectedItem.ToString();
            
            ServiceController sc = new ServiceController(selectedItem);

            sc.Stop();

            reloadServices(null, EventArgs.Empty);

        }

        private void startServiceBtn_Click(object sender, EventArgs e)
        {
            string selectedItem = stoppedList.SelectedItem.ToString();
            
            ServiceController sc = new ServiceController(selectedItem);
           
            sc.Start();

            reloadServices(null, EventArgs.Empty);

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string searchString = searchBar.Text;
            if (!string.IsNullOrEmpty(searchString))
            {
                // Find the item in the list and store the index to the item.
                int runningIndex = runningList.FindString(searchString);
                int stoppedIndex = stoppedList.FindString(searchString);
                // Determine if a valid index is returned. Select the item if it is valid.
                if (runningIndex != -1 && stoppedIndex == -1)
                    runningList.SetSelected(runningIndex, true);
                else if (stoppedIndex != -1 &&  runningIndex == -1)
                    stoppedList.SetSelected(stoppedIndex, true);
                else 
                    MessageBox.Show("Service not found.");
            }
        }

        private void funktionsübersichtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Update (manual): To manually update the application, click on Actions -> Refresh (Manual)\n\nAuto - Refresh: To enable or disable auto - refresh, click on Actions->Auto - Refresh");
        }

        private void aktualisierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reloadServices(null, EventArgs.Empty);
        }

        private void reloadServices(object sender, EventArgs e)
        {
            stoppedSortedBy_SelectedIndexChanged(null, EventArgs.Empty);
            runningSortedBy_SelectedIndexChanged(null, EventArgs.Empty);
        }

        private Timer refreshTimer;

        private void autoRefreshAktivierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (refreshTimer == null && autoRefreshAktivierenToolStripMenuItem.Checked)
            {
                refreshTimer = new Timer();
                refreshTimer.Interval = 30 * 1000;
                refreshTimer.Tick += reloadServices;
                refreshTimer.Start();
            } else
            {
                refreshTimer.Stop();
            }

        }
    }
}
