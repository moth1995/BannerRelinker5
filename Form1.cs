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

namespace BannerRelinker5
{
    public partial class Form1 : Form
    {

        public class BinaryBannerFile
        {
            public string[] binsIds = new string[221];
            public int[] texturesIds = new int[221];
        }

        BinaryBannerFile unknow17 = new BinaryBannerFile();
        string file = "";

        public Form1()
        {
            InitializeComponent();
            // Loading teamlist from the csv file
            ReadingCSVFile();

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string IntToBinId(int binId)
        {
            switch(binId)
            {
                case 0:
                    return "unknow_11412.bin";
                case 1:
                    return "unknow_11413.bin";
                case 2:
                    return "unknow_11414.bin";
                case 3:
                    return "unknow_11415.bin";
                case 256:
                    return "unknow_11404.bin";
                case 257:
                    return "unknow_11405.bin";
                case 258:
                    return "unknow_11406.bin";
                case 259:
                    return "unknow_11407.bin";
                case 260:
                    return "unknow_11408.bin";
                case 512:
                    return "unknow_11409.bin";
                case 513:
                    return "unknow_11410.bin";
                case 514:
                    return "unknow_11411.bin";
                default:
                    return "unknow_?????.bin";
            }
        }
        private int BinIdToInt(string binName)
        {
            switch (binName)
            {
                case "unknow_11412.bin":
                    return 0;
                case "unknow_11413.bin":
                    return 1;
                case "unknow_11414.bin":
                    return 2;
                case "unknow_11415.bin":
                    return 3;
                case "unknow_11404.bin":
                    return 256;
                case "unknow_11405.bin":
                    return 257;
                case "unknow_11406.bin":
                    return 258;
                case "unknow_11407.bin":
                    return 259;
                case "unknow_11408.bin":
                    return 260;
                case "unknow_11409.bin":
                    return 512;
                case "unknow_11410.bin":
                    return 513;
                case "unknow_11411.bin":
                    return 514;
                default:
                    return 0;
            }

        }
        public void LoadBinBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = this.Text;
            openDialog.Filter = "bin_004 Files (*.bin_004)|*.bin_004" + "|" +
                                "All Files (*.*)|*.*";
            //BinaryBannerFile unknow17 = new BinaryBannerFile();
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                file = openDialog.FileName;
                FileStream readStream;
                //BinaryBannerFile unknow17 = new BinaryBannerFile();
                try
                {
                    readStream = new FileStream(file, FileMode.Open);
                    BinaryReader readBinary = new BinaryReader(readStream);
                    //readBinary.BaseStream.Seek(0, 0);
                    int i;
                    for (i = 0; i < unknow17.texturesIds.Length; i++)
                    {
                        unknow17.texturesIds[i] = readBinary.ReadInt16() + 1;
                        unknow17.binsIds[i] = IntToBinId(readBinary.ReadInt16());
                        //MessageBox.Show($"bin id is {unknow17.binsIds[i]}, texture id is {unknow17.texturesIds[i]}");
                    }
                    //int textureId = readBinary.ReadInt16();
                    //string binId = IntToBinId(readBinary.ReadInt16());
                    readStream.Close();
                    //MessageBox.Show($"bin id is {binId}, texture id is {textureId}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                file = "";
                MessageBox.Show("Please Select a file!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BinCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            // Change the length of the text box depending on what the user has 
            // selected and committed using the SelectionLength property.
            switch ((string)senderComboBox.SelectedItem)
            {
                case "unknow_11408.bin":
                    this.TextureCmb.Items.Clear();
                    this.TextureCmb.Items.AddRange(Enumerable.Range(1, 18).Cast<object>().ToArray());
                    break;
                case "unknow_11411.bin":
                    this.TextureCmb.Items.Clear();
                    this.TextureCmb.Items.AddRange(Enumerable.Range(1, 10).Cast<object>().ToArray());
                    break;
                case "unknow_11414.bin":
                    this.TextureCmb.Items.Clear();
                    this.TextureCmb.Items.AddRange(Enumerable.Range(1, 16).Cast<object>().ToArray());
                    break;
                case "unknow_11415.bin":
                    this.TextureCmb.Items.Clear();
                    this.TextureCmb.Items.AddRange(Enumerable.Range(1, 8).Cast<object>().ToArray());
                    break;
                default:
                    this.TextureCmb.Items.Clear();
                    this.TextureCmb.Items.AddRange(Enumerable.Range(1, 40).Cast<object>().ToArray());
                    break;
            }
        }
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (file != "" && TeamsLstBox.SelectedItem != null)
            {
                //MessageBox.Show(unknow17.texturesIds.GetValue(TeamsLstBox.SelectedIndex).ToString());
                //MessageBox.Show(unknow17.binsIds.GetValue(TeamsLstBox.SelectedIndex).ToString());
                //MessageBox.Show(TeamsLstBox.SelectedIndex.ToString());
                BinCmb.SelectedItem = unknow17.binsIds.GetValue(TeamsLstBox.SelectedIndex).ToString();
                TextureCmb.SelectedItem = unknow17.texturesIds.GetValue(TeamsLstBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("First you need to select your unknow_00017.bin_004 file!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveBinBtn_Click(object sender, EventArgs e)
        {
            if (file != "" && TeamsLstBox.SelectedItem != null && TextureCmb.SelectedItem != null && BinCmb.SelectedItem != null)
            {
                //BinaryBannerFile unknow17 = new BinaryBannerFile();
                byte[] textureIdBytes = BitConverter.GetBytes((UInt16)TextureCmb.SelectedIndex);
                byte[] binIdBytes = BitConverter.GetBytes((UInt16)BinIdToInt(BinCmb.SelectedItem.ToString()));
                //System.Diagnostics.Debug.WriteLine(BitConverter.ToString(bytes));
                try
                {
                    using (Stream stream = File.Open(file, FileMode.Open))
                    {
                        // First we move into the team banner relink offset
                        stream.Position = TeamsLstBox.SelectedIndex * 4;
                        stream.Write(textureIdBytes, 0, 2);
                        stream.Write(binIdBytes, 0, 2);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(),this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An error has ocurred, maybe you haven't select a bin file\n" +
                    "or you haven't choose a team, or bin id and texture are empty, please check again",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReadingCSVFile()
        {
            string teamlistFile = @"teamlist.csv";
            // First we try to load from the csv file the teamnames
            if (File.Exists(teamlistFile))
            {
                using (StreamReader teamListCSV = new StreamReader(teamlistFile))
                {
                    string line;
                    while ((line = teamListCSV.ReadLine()) != null)
                        TeamsLstBox.Items.Add(line);
                }
            }
            else
            {
                // If we dont find the file then we create the list manually
                string[] fixedTeamlist = {  "Austria",
                                            "Belgium",
                                            "Bulgaria",
                                            "Croatia",
                                            "Czech",
                                            "Denmark",
                                            "England",
                                            "Finland",
                                            "France",
                                            "Germany",
                                            "Greece",
                                            "Hungary",
                                            "Ireland",
                                            "Italy",
                                            "Latvia",
                                            "Netherlands",
                                            "Northern Ireland",
                                            "Norway",
                                            "Poland",
                                            "Portugal",
                                            "Romania",
                                            "Russia",
                                            "Scotland",
                                            "Serbia and Montenegro",
                                            "Slovakia",
                                            "Slovenia",
                                            "Spain",
                                            "Sweden",
                                            "Switzerland",
                                            "Turkey",
                                            "Ukraine",
                                            "Wales",
                                            "Cameroon",
                                            "Cote d'Ivoire",
                                            "Morocco",
                                            "Nigeria",
                                            "Senegal",
                                            "South Africa",
                                            "Tunisia",
                                            "Costa Rica",
                                            "Mexico",
                                            "United States",
                                            "Argentina",
                                            "Brazil",
                                            "Chile",
                                            "Colombia",
                                            "Ecuador",
                                            "Paraguay",
                                            "Peru",
                                            "Uruguay",
                                            "Venezuela",
                                            "China",
                                            "Iran",
                                            "Japan",
                                            "Saudi Arabia",
                                            "South Korea",
                                            "Australia",
                                            "Classic Argentina",
                                            "Classic Brazil",
                                            "Classic England",
                                            "Classic France",
                                            "Classic Germany",
                                            "Classic Italy",
                                            "Classic Netherlands",
                                            "Arsenal",
                                            "West Midlands Village",
                                            "West Midlands City",
                                            "Lancashire",
                                            "Middlebrook",
                                            "South East London Reds",
                                            "Chelsea",
                                            "Merseyside Blue",
                                            "West London White",
                                            "Merseyside Red",
                                            "Man Blue",
                                            "Man Red",
                                            "Teesside",
                                            "Tyneside",
                                            "Pompy",
                                            "Wearside",
                                            "North East London",
                                            "West Midlands Stripes",
                                            "East London",
                                            "Lancashire Athletic",
                                            "Corse Sud",
                                            "Azur",
                                            "Bourgogne",
                                            "Aquitaine",
                                            "Sarthe",
                                            "Pas de Calais",
                                            "Rhone",
                                            "Moselle",
                                            "Meurthe-et-Moselle",
                                            "Loire Océan",
                                            "Alpes Maritimes",
                                            "Bouches du Rhone",
                                            "Ile De France",
                                            "Nord",
                                            "Bretagne",
                                            "Somesterrine",
                                            "Franche-Comté",
                                            "Alsace",
                                            "Garonne",
                                            "Aube",
                                            "Domstadt",
                                            "Alm",
                                            "Rhein",
                                            "Isar",
                                            "Westfalen",
                                            "Fohlen",
                                            "Stahlstadt",
                                            "Rhein-Main",
                                            "Hanseaten",
                                            "Niedersachsen",
                                            "Hauptstadt",
                                            "Pfalz",
                                            "Karneval",
                                            "Franken",
                                            "Ruhr",
                                            "Neckar",
                                            "Autostadt",
                                            "Weser",
                                            "A.C. Milan",
                                            "A.S. Roma",
                                            "Ascoli",
                                            "Teste Di Moro",
                                            "Chievo Verona",
                                            "Empoli",
                                            "Fiorentina",
                                            "Inter",
                                            "Juventus",
                                            "Lazio",
                                            "Lecce",
                                            "Livorno",
                                            "Messina",
                                            "Palermo",
                                            "Parma",
                                            "Reggina",
                                            "Sampdoria",
                                            "Siena",
                                            "Treviso",
                                            "Udinese",
                                            "ADO Den Haag",
                                            "Ajax",
                                            "AZ",
                                            "FC Groningen",
                                            "FC Twente",
                                            "FC Utrecht",
                                            "Feyenoord",
                                            "Heracles Almelo",
                                            "NAC Breda",
                                            "NEC Nijmegen",
                                            "PSV Eindhoven",
                                            "RBC Roosendaal",
                                            "RKC Waalwijk",
                                            "Roda JC",
                                            "SC Heerenveen",
                                            "Sparta Rotterdam",
                                            "Vitesse",
                                            "Willem II",
                                            "Alaves",
                                            "At. Osasuna",
                                            "Athletic Club",
                                            "C. Atlético Madrid",
                                            "Cadiz",
                                            "Celta",
                                            "F.C. Barcelona",
                                            "Getafe C.F.",
                                            "Málaga C.F.",
                                            "R. Betis",
                                            "R. Madrid",
                                            "R. Racing C.",
                                            "R. Sociedad",
                                            "R. Zaragoza",
                                            "R.C. Deportivo",
                                            "R.C.D. Espanyol",
                                            "R.C.D. Mallorca",
                                            "Sevilla F.C.",
                                            "Valencia C.F.",
                                            "Villarreal C.F.",
                                            "Lisbonera",
                                            "FC Bosphorus",
                                            "Celtic",
                                            "Djurgardens IF",
                                            "Dynamo Kiev",
                                            "FC Belgium",
                                            "FC Kopenhagen",
                                            "FC Porto",
                                            "Constanti",
                                            "Galatasaray",
                                            "Russia Rail FC",
                                            "Peloponnisos",
                                            "Athenakos FC",
                                            "Rangers",
                                            "Rosenborg BK",
                                            "Bruxelles",
                                            "Sheffcor Domake",
                                            "AC Czech",
                                            "Esportiva",
                                            "Caopolo",
                                            "PES United",
                                            "WE United",
                                            "World All-Stars",
                                            "European All-Stars",
                                            "North American All-Stars",
                                            "South American All-Stars",
                                            "Asia Oceanian All-Stars",
                                            "African All-Stars",
                                            "Master League Youth Squad",
                                            "Master League Veterans",
                                            "Galacticos",
                                            "The Jaguars",
                                            "The Oxen",
                                            "The Goliaths",
                                            "Little Rascals",
                                            "The Lefties",
                                            "Gli Pelati",
                                            "Goalies",
                                            "ML United",
                                            "Canuch",
                                            "Rawore" };
                TeamsLstBox.Items.AddRange(fixedTeamlist);
            }
        }
    }
}