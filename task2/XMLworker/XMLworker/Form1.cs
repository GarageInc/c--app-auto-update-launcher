using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using log4net;
using System.Reflection;
using XMLworker.Services;

namespace XMLworker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        protected BindingList<XMLworker.models.File> filesFromFS = new BindingList<models.File>();
        protected BindingList<XMLworker.models.File> filesFromDatabase = new BindingList<models.File>();

        protected XMLDbContext db;

        protected void bOpenXML_Click(object sender, EventArgs e)
        {
            log.Info("Start opening file");

            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog.Filter = "xml files |*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ( ( myStream = openFileDialog.OpenFile()) != null)
                    {
                        XmlSerializer formatter = new XmlSerializer(typeof(XMLworker.models.File));

                        if ( FileService.IsRequiredFileName(openFileDialog.SafeFileName))
                        {
                            using ( myStream)
                            {
                                XMLworker.models.File file = (XMLworker.models.File)formatter.Deserialize(myStream);

                                filesFromFS.Add( file);
                            }
                        } else
                        {
                            throw new Exception("Not supported file name");
                        }
                    }
                }
                catch (Exception ex)
                {
                    var message = "Error: Could not read file from disk. Original error: " + ex.Message;

                    log.Error(message);

                    MessageBox.Show(message);
                }
            }

            openFileDialog.Dispose();


        }

        protected void bGenerate_Click(object sender, EventArgs e)
        {
            log.Info("Start creating test file");

            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(models.File));

            var fileSavePath = String.Format("{0}\\{1}", Directory.GetCurrentDirectory(), "file_example.xml");

            var file = new models.File();

            file.Name = "testName";
            file.FileVersion = "1.0.0.1";
            file.DateTime = DateTime.Now;

            using (FileStream fs = new FileStream(fileSavePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, file);
            }

            var message = String.Format("Success by creating file: {0}", fileSavePath);
            log.Info(message);
            MessageBox.Show(message);
        }

        protected void bSave_Click(object sender, EventArgs e)
        {
            log.Info("Start savinf files in DB");

            foreach (var file in filesFromFS)
            {
                db.Files.Add(file);
            }

            db.SaveChanges();

            filesFromFS.Clear();

            var message = "Files added to database";

            log.Info(message);                     
            MessageBox.Show(message);
            loadFilesFromDatabase();
        }


        protected void bLoad_Click(object sender, EventArgs e)
        {
            loadFilesFromDatabase();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            log.Info("App started");

            db = new XMLDbContext();

            setDgwSettings(dgwFS, bindingSource_dgwFS, filesFromFS);
            setDgwSettings(dgwDatabase, bindingSource_dgwDatabase, filesFromDatabase);
        }

        protected void setDgwSettings(DataGridView dgw, BindingSource bSource, BindingList<models.File> bList)
        {
            bSource.DataSource = bList;
            dgw.DataSource = bSource;
            dgw.AutoGenerateColumns = true;
        }

        // not optimize
        void loadFilesFromDatabase()
        {
            log.Info("Loading files from DB");

            filesFromDatabase.Clear();

            var files = db.Files.ToList();

            foreach (var file in files)
            {
                filesFromDatabase.Add(file);
            }

            log.Info("Loaded files from DB");
        }

    }
}
