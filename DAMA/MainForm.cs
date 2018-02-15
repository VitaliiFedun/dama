using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Outlook = Microsoft.Office.Interop.Outlook;



namespace DAMA
{
    public partial class FormMain : Form
    {
        protected string _store, _subject, _attachpath;
        protected bool _runstage;

        //
        // set & get protected bool _runstage
        //

        public void SetRunStage(bool value)
        {

            _runstage = value;
        }

        public bool GetRunStage()
        {

            return _runstage;
        }


        //
        // set & get protected string _store
        //

        public void SetStore(string value)
        {

            _store = value;
        }

        public string GetStore()
        {

            return _store ;
        }

        //
        // set & get protected string _subject
        //

        public void SetSubject(string value)
        {

            _subject = value;
        }

        public string GetSubject()
        {

            return _subject;
        }

        //
        // set & get protected string _attachpath;
        //

        public void SetAttachpath (string value)
        {

            _attachpath = value;
        }

        public string GetAttachpath ()
        {

            return _attachpath;
        }




        IniFiles.IniFile MainIniFiles = new IniFiles.IniFile("Mailconfig.ini");

        public FormMain()
        {
            InitializeComponent();
        }

  /*      private void SetupToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RunToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

   */
        private void ToolStripButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();

        }

        public void ShowMyDialogBox()
        {
            AboutBoxMain testDialog = new AboutBoxMain();

            // Show testDialog as a modal dialog 
            testDialog.ShowDialog(this);


            testDialog.Dispose();
        }

        
        private void FormMain_Shown(object sender, EventArgs e)
        {

            // ShowDisplayCountMails( );
        }

  

        private void ShowDisplayCountMails()

        {

            Outlook.Application objOutlook = new Outlook.Application();
            Outlook.Explorer _actExplorer = objOutlook.Application.ActiveExplorer();

            Outlook.Stores stores = objOutlook.Application.Session.Stores;

            if (_actExplorer == null)
            {
                ToolStripStatusLabel1.Text = "OutLook not running!";
                return;
            }

            dataGridViewInfo.Rows.Clear();

            dataGridViewInfo.Visible = true;
            comboBoxStore.Items.Clear();



            foreach (Outlook.Store store in stores)

            {


                string NameStores = store.DisplayName;
                int _colItemsAlls = 0;
                int _colItemsUnread = 0;
                Outlook.MAPIFolder inbox = store.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
                Outlook.Items inBoxItems = inbox.Items; //Outlook.MAPIFolder inBox
                _colItemsAlls = inBoxItems.Count;

                inBoxItems = inBoxItems.Restrict(" [Unread] = true");
                _colItemsUnread = inBoxItems.Count;

                dataGridViewInfo.Rows.Add(NameStores, _colItemsAlls, _colItemsUnread);
                comboBoxStore.Items.Add(NameStores);


            }
        }


        private void StartRun()
        {
            string _Subject = GetSubject();
            string _strPath = GetAttachpath();
            string _strPromt = "Обробка закінчена";
            Outlook.Application objOutlook = new Outlook.Application();
            Outlook.Explorer _actExplorer = objOutlook.Application.ActiveExplorer();

            Outlook.Stores stores = objOutlook.Application.Session.Stores;

            if (_actExplorer == null)
            {
                ToolStripStatusLabel1.Text = "OutLook not running!";
                return;
            }



            Outlook.Store storework = null;
            for (int i = 1; i <= stores.Count; i++)
            {
                if (stores[i].DisplayName == GetStore())
                {
                    storework = stores[i];
                    break;
                }
            }


            if (storework == null)
            {
                ToolStripStatusLabel1.Text = "OutLook store:" + GetStore() + "not found!";
                return;
            }


            Outlook.MAPIFolder inBox = storework.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderInbox);
            Outlook.Items inBoxItems = inBox.Items; //Outlook.MAPIFolder inBox
            Outlook.MAPIFolder OutBoxSubject = null;

            foreach (Outlook.Folder folder in inBox.Folders)
            {
                if (folder.Name.Equals(_Subject))
                {
                    OutBoxSubject = folder;
                }
            }

            if (OutBoxSubject == null)
            {
                OutBoxSubject = inBox.Folders.Add(_Subject);
            }

          
            ToolStripStatusLabel1.Text = "Вхідних : " + inBoxItems.Count;
            //inBoxItems = inBoxItems.Restrict( " [Unread] = true");
            inBoxItems = inBoxItems.Restrict("[Subject] = " + _Subject + "");

            ToolStripStatusLabel2.Visible = true;
            ToolStripStatusLabel3.Visible = true;
            ToolStripProgressBarMain.Visible = true;
            ToolStripProgressBarMain.Maximum = inBoxItems.Count;
            ToolStripProgressBarMain.Value = 0;

            try
            {
                // BASIC CICLE

                SetRunStage(true);

                int _allattachment = 0, _allmail = 1;

                for (int i = inBoxItems.Count; i > 0; i--)

                {
                    Application.DoEvents();
                    Outlook.MailItem workLetter = inBoxItems[i] as Outlook.MailItem;

                    ToolStripStatusLabel3.Text = "Обробка листа: " + _allmail++;
                    ToolStripProgressBarMain.Value++;
                    Application.DoEvents();


                    if (!GetRunStage())
                    {
                        _strPromt = "Обробка перервана";
         
                        break;
                    }

                    Application.DoEvents();

                    if (workLetter.Subject == _Subject)

                    {
                        if (workLetter.Attachments.Count > 0)
                        {
                            string _folder = "";

                            _allattachment++;

                            for (int j = 1; j <= workLetter.Attachments.Count; j++)
                            {
                                _folder = MakeFolderForAttacment(workLetter.Attachments[j].FileName);
                                if (!Directory.Exists(_folder))
                                {
                                    Directory.CreateDirectory(_folder);
                                }
                                workLetter.Attachments[j].SaveAsFile(Path.Combine(_folder + "\\" + workLetter.Attachments[j].FileName));
                                ToolStripStatusLabel2.Text = "Оброблено вкладень: " + _allattachment;

                            } 
                            workLetter.Move(OutBoxSubject);
                        }

                        else
                        {
                            workLetter.Delete();
                        }
                        
                    }

                }


            }// end try


            catch (Exception ex)
            {
                string errorInfo = (string)ex.Message
                    .Substring(0, 11);
                if (errorInfo == "Cannot save")
                {
                    MessageBox.Show(@"Bad folder to a save attacment");
                }
                MessageBox.Show(ex.Message);
                _strPromt = "OutLook was lost!";

            }

            // finally
            {
                EndRun(_strPromt);
                inBoxItems = null;
                objOutlook = null;

            }

        }

        private void EndRun(string _strPromtValue)
        {
            ToolStripStatusLabel3.Text = _strPromtValue;
            ToolStripStatusLabel3.Visible = true;
            SetRunStage(false);


        }


        private string  MakeFolderForAttacment(string FileName)
        {

         return  Path.Combine(GetAttachpath() + "\\" + FileName.Substring(5, 4) + "_"
                                                     + FileName.Substring(9, 2) + "_"
                                                     + FileName.Substring(11, 2));


        }


        private void ToolStripButtonRun_Click(object sender, EventArgs e)
        {
            SetupButton();
            ShowDisplayCountMails();
            StartRun();
            ShowDisplayCountMails();
            SetupButton();
        }

        private void SetupButton()
        {
            ToolStripButtonRun.Visible = !ToolStripButtonRun.Visible;
            ToolStripButtonSetup.Visible = !ToolStripButtonSetup.Visible;
            ToolStripButtonCancel.Visible = !ToolStripButtonCancel.Visible;
            ToolStripButtonExit.Visible = !ToolStripButtonExit.Visible;
        
        }

        private void ToolStripButtonCancel_Click(object sender, EventArgs e)
        {
            SetRunStage(false);
            //SetupButton();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupEnabled(false);
            LoadSetting();
            CheckOutlook();
        }

        private void SetupEnabled(bool _result)
        {

            textBoxSubject.Enabled = _result;
            textBoxAttachPath.Enabled = _result;
            buttonSetPath.Visible = _result;
            buttonSaveSetup.Visible = _result;
            ButtonCancelSetup.Visible = _result;

            splitContainer1.Panel1Collapsed = !_result;
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel1Collapsed;
            // panelInfo.Visible = !_result;
            ToolStripButtonRun.Visible = !_result;
            ToolStripButtonExit.Visible = !_result;
        }

        private void CheckOutlook()
        {


            // throw new NotImplementedException();
        }

        private void DellStatusPromt()
        {
            ToolStripStatusLabel1.Text = "";
            ToolStripStatusLabel2.Text = "";
            ToolStripStatusLabel3.Text = "";

        }

        private void LoadSetting()
        {
            DellStatusPromt();

            try
            {
                ShowDisplayCountMails();
            }
            catch
            {
                ToolStripStatusLabel1.Text = "OutLook not running!";
                return;
            }

            LoadSetupValue();
            VisionerySetupValue();

            if (comboBoxStore.Items.IndexOf(GetStore()) < 0)
            {
                MessageBox.Show("Bed setup for Store! Check, please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetupEnabled(true);
            }

        }
        

        /* 
        // load value from ini-file
        */

        private void  LoadSetupValue()
        {
            SetStore(MainIniFiles.ReadINI("Setup", "Store"));
            SetSubject(MainIniFiles.ReadINI("Setup", "Subject"));
            SetAttachpath(MainIniFiles.ReadINI("Setup", "Path"));

        }
        /*
         * restore value in texts components/
         */ 

        private void VisionerySetupValue()
        {
            comboBoxStore.Text = GetStore();
            textBoxSubject.Text = GetSubject(); //  MainIniFiles.ReadINI("Setup", "Subject");
            textBoxAttachPath.Text = GetAttachpath(); // MainIniFiles.ReadINI("Setup", "Path");
            
        }
        
        
        // save setup value to 

        private void ButtonSaveSetup_Click(object sender, EventArgs e)
        {
            MainIniFiles.Write("Setup", "Store", comboBoxStore.Text);
            MainIniFiles.Write("Setup", "Subject", textBoxSubject.Text);
            MainIniFiles.Write("Setup", "Path", textBoxAttachPath.Text);

            LoadSetupValue();
            SetupEnabled(false);
        }

        private void ToolStripButtonSetup_Click(object sender, EventArgs e)
        {
            SetupEnabled(true);
        }

        /*
         * show dialog folder to select attach path
         */

        private void ButtonSetPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialogMain.Description = "Select folder for save attachment";


            if (folderBrowserDialogMain.ShowDialog() == DialogResult.OK)
            {
                textBoxAttachPath.Text = folderBrowserDialogMain.SelectedPath;
            }
        }


        /*
         * if press "cancel" buttom
         * then restore value from ini-files
         * 
         */

        private void ButtonCancelSetup_Click(object sender, EventArgs e)
        {
            LoadSetupValue();
            VisionerySetupValue();
            SetupEnabled(false);

        }

       
    }
}

        

            

