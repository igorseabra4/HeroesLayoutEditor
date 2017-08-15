using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace HeroesLayoutEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (File.Exists("ObjectList.ini") & File.Exists("ListList.ini"))
                ReadObjectListData("ObjectList.ini", "ListList.ini");
            else
            {
                MessageBox.Show("Error loading external.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            NumericPosX.Maximum = decimal.MaxValue;
            NumericPosX.Minimum = decimal.MinValue;
            NumericPosY.Maximum = decimal.MaxValue;
            NumericPosY.Minimum = decimal.MinValue;
            NumericPosZ.Maximum = decimal.MaxValue;
            NumericPosZ.Minimum = decimal.MinValue;

            NumericRotX.Maximum = decimal.MaxValue;
            NumericRotX.Minimum = decimal.MinValue;
            NumericRotY.Maximum = decimal.MaxValue;
            NumericRotY.Minimum = decimal.MinValue;
            NumericRotZ.Maximum = decimal.MaxValue;
            NumericRotZ.Minimum = decimal.MinValue;

            DisableAllEditors();

            ProgramIsChangingStuff = false;
        }
        
        public class ObjectEntry
        {
            public byte List;
            public byte Type;
            public string Name;
            public bool NoMiscSettings;
            public string DebugName;
            public string LinkID;
            public string Description;

            public ObjectEntry()
            {
                NoMiscSettings = false;
            }

            public override string ToString()
            {
                if (Name != "")
                    return Type.ToString("X2") + " " + Name;
                else if (DebugName != "")
                    return Type.ToString("X2") + " " + DebugName;
                else
                    return Type.ToString("X2") + " Unknown/Unused";
            }

            public string GetName()
            {
                if (Name != "")
                    return Name;
                else if (DebugName != "")
                    return DebugName;
                else
                    return "Unknown/Unused";
            }
        }

        static List<ObjectEntry> ObjectEntryStream = new List<ObjectEntry>();

        public class ListEntry
        {
            public string ListName;
            public byte List;

            public ListEntry() { }

            public override string ToString()
            {
                return List.ToString("X2") + " " + ListName;
            }
        }

        void ReadObjectListData(string FileName, string ListFileName)
        {
            string[] ObjectListFile = File.ReadAllLines(FileName);

            byte List = 0;
            byte Type = 0;
            string Name = "";
            bool NoMiscSettings = false;
            string DebugName = "";
            string LinkID = "";
            string Description = "";

            foreach (string i in ObjectListFile)
            {
                if (i.StartsWith("["))
                {
                    List = Convert.ToByte(i.Substring(1, 2), 16);
                    Type = Convert.ToByte(i.Substring(5, 2), 16);
                }
                else if (i.StartsWith("Object="))
                    Name = i.Split('=')[1];
                else if (i.StartsWith("NoMiscSettings="))
                    NoMiscSettings = Convert.ToBoolean(i.Split('=')[1]);
                else if (i.StartsWith("Debug="))
                    DebugName = i.Split('=')[1];
                else if (i.StartsWith("LinkID="))
                    LinkID = i.Split('=')[1];
                else if (i.StartsWith("Description="))
                    Description = i.Split('=')[1];
                else if (i.StartsWith("EndOfFile"))
                {
                    ObjectEntryStream.Add(new ObjectEntry()
                    {
                        List = List,
                        Type = Type,
                        Name = Name,
                        NoMiscSettings = NoMiscSettings,
                        DebugName = DebugName,
                        LinkID = LinkID,
                        Description = Description
                    });
                    break;
                }
                else if (i.Length == 0)
                {
                    ObjectEntryStream.Add(new ObjectEntry()
                    {
                        List = List,
                        Type = Type,
                        Name = Name,
                        NoMiscSettings = NoMiscSettings,
                        DebugName = DebugName,
                        LinkID = LinkID,
                        Description = Description
                    });
                    List = 0;
                    Type = 0;
                    Name = "";
                    NoMiscSettings = false;
                    DebugName = "";
                    LinkID = "";
                    Description = "";
                }
            }

            string[] ListListFile = File.ReadAllLines(ListFileName);

            ComboBoxList.Items.Clear();

            foreach (string i in ListListFile)
            {
                ComboBoxList.Items.Add(new ListEntry
                {
                    List = Convert.ToByte(i.Substring(0, 2), 16),
                    ListName = i.Substring(3)
                });
            }
        }

        public class SETObject
        {
            public string NameInternal;

            public byte[] MiscSettings;
            public float X;
            public float Y;
            public float Z;

            public int XRot;
            public int YRot;
            public int ZRot;

            public byte List;
            public byte Type;
            public byte Link;
            public byte RendDist;

            public bool HasMiscID;
            public bool isSelected;

            public SETObject()
            {
                HasMiscID = true;
                isSelected = false;
                MiscSettings = new byte[36];
                RendDist = 10;
            }

            public string GetName()
            {
                if (Link == 0)
                    return NameInternal;
                else
                    return NameInternal + " (" + Link.ToString() + ")";
            }

            public void FindName()
            {
                NameInternal = "Unknown/Unused";
                foreach (ObjectEntry j in ObjectEntryStream)
                    if (j.List == List & j.Type == Type)
                    {
                        NameInternal = j.GetName();
                        break;
                    }
            }
        }

        public static List<SETObject> SETObjectList = new List<SETObject>();

        static bool ProgramIsChangingStuff = false;
        static bool ProcessIsAttached = false;
        static int SelectedObject = -1;

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SETObjectList.Clear();
            ListBoxObjects.Items.Clear();
            DisableAllEditors();
            TextBoxNumOfObjects.Text = "0 objects";
            OpenLayoutFile.FileName = null;
        }

        OpenFileDialog OpenLayoutFile = new OpenFileDialog();

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLayoutFile.Filter = ".bin files|*.bin";
            DialogResult result = OpenLayoutFile.ShowDialog();
            if (result == DialogResult.OK)
                LoadLayoutFile();
        }

        SaveFileDialog SaveLayoutFile = new SaveFileDialog();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenLayoutFile.FileName != null)
                SaveFile(OpenLayoutFile.FileName);
            else
            {
                SaveLayoutFile.Filter = ".bin files|*.bin";
                DialogResult result = SaveLayoutFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    OpenLayoutFile.FileName = SaveLayoutFile.FileName;
                    SaveFile(OpenLayoutFile.FileName);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveLayoutFile.Filter = ".bin files|*.bin";
            DialogResult result = SaveLayoutFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                OpenLayoutFile.FileName = SaveLayoutFile.FileName;
                SaveFile(OpenLayoutFile.FileName);
            }
        }
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Heroes Layout Editor release 7 by igorseabra4", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        static int SwitchEndInt(byte[] a)
        {
            byte[] c = { a[3], a[2], a[1], a[0] };
            return BitConverter.ToInt32(c, 0);
        }
        
        static float SwitchEndFloat(byte[] a)
        {
            byte[] c = { a[3], a[2], a[1], a[0] };
            return BitConverter.ToSingle(c, 0);
        }

        public void LoadLayoutFile()
        {
            SETObjectList.Clear();
            ListBoxObjects.Items.Clear();

            BinaryReader LayoutFileReader = new BinaryReader(new FileStream(OpenLayoutFile.FileName, FileMode.Open));

            for (int i = 0; i < 2048; i++)
            {
                SETObject TempObject = new SETObject();

                LayoutFileReader.BaseStream.Position = 0x30 * i;
                if (LayoutFileReader.BaseStream.Position == LayoutFileReader.BaseStream.Length)
                    break;

                TempObject.X = SwitchEndFloat(LayoutFileReader.ReadBytes(4));
                TempObject.Y = SwitchEndFloat(LayoutFileReader.ReadBytes(4));
                TempObject.Z = SwitchEndFloat(LayoutFileReader.ReadBytes(4));
                TempObject.XRot = SwitchEndInt(LayoutFileReader.ReadBytes(4));
                TempObject.YRot = SwitchEndInt(LayoutFileReader.ReadBytes(4));
                TempObject.ZRot = SwitchEndInt(LayoutFileReader.ReadBytes(4));
                LayoutFileReader.BaseStream.Position += 16;
                TempObject.List = LayoutFileReader.ReadByte();
                TempObject.Type = LayoutFileReader.ReadByte();
                TempObject.Link = LayoutFileReader.ReadByte();
                TempObject.RendDist = LayoutFileReader.ReadByte();

                if (TempObject.List == 0 & TempObject.Type == 0)
                    continue;

                int MiscSettings = SwitchEndInt(LayoutFileReader.ReadBytes(4));
                if (MiscSettings == 0)
                    TempObject.HasMiscID = false;
                else
                {
                    LayoutFileReader.BaseStream.Position = 0x18000 + (0x24 * MiscSettings);
                    TempObject.MiscSettings = LayoutFileReader.ReadBytes(36);
                }

                TempObject.FindName();

                SETObjectList.Add(TempObject);
            }
            LayoutFileReader.Close();

            LabelFileLoaded.Text = "File: " + OpenLayoutFile.FileName;
            TextBoxNumOfObjects.Text = SETObjectList.Count.ToString() + " objects";

            foreach (SETObject i in SETObjectList)
                ListBoxObjects.Items.Add(i.GetName());
        }

        public static bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void SaveFile(string OutputFileName)
        {
            if (IsFileLocked(new FileInfo(OutputFileName)))
            {
                DialogResult result = MessageBox.Show("File is being used by another process", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                    SaveFile(OutputFileName);
                return;
            }

            BinaryWriter LayoutFileWriter = new BinaryWriter(new FileStream(OutputFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));

            byte CurrentNum;

            if (OutputFileName.Contains("P1"))
                CurrentNum = 0x20;
            else if (OutputFileName.Contains("P2"))
                CurrentNum = 0x40;
            else if (OutputFileName.Contains("P3"))
                CurrentNum = 0x60;
            else if (OutputFileName.Contains("P4"))
                CurrentNum = 0x80;
            else if (OutputFileName.Contains("P5"))
                CurrentNum = 0xA0;
            else
                CurrentNum = 0;

            int j = 1;

            foreach (SETObject i in SETObjectList)
            {
                if (i.List == 0 & i.Type == 0) continue;

                LayoutFileWriter.Write(BitConverter.GetBytes(i.X)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.X)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.X)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.X)[0]);

                LayoutFileWriter.Write(BitConverter.GetBytes(i.Y)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Y)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Y)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Y)[0]);

                LayoutFileWriter.Write(BitConverter.GetBytes(i.Z)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Z)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Z)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.Z)[0]);

                LayoutFileWriter.Write(BitConverter.GetBytes(i.XRot)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.XRot)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.XRot)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.XRot)[0]);

                LayoutFileWriter.Write(BitConverter.GetBytes(i.YRot)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.YRot)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.YRot)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.YRot)[0]);

                LayoutFileWriter.Write(BitConverter.GetBytes(i.ZRot)[3]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.ZRot)[2]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.ZRot)[1]);
                LayoutFileWriter.Write(BitConverter.GetBytes(i.ZRot)[0]);

                LayoutFileWriter.Write(new byte[] { 0, 2, CurrentNum, 9, 0, 0, 0, 0 });
                LayoutFileWriter.Write(new byte[] { 0, 2, CurrentNum, 9, 0, 0, 0, 0 });

                LayoutFileWriter.Write(i.List);
                LayoutFileWriter.Write(i.Type);
                LayoutFileWriter.Write(i.Link);
                LayoutFileWriter.Write(i.RendDist);

                if (i.HasMiscID == true)
                {
                    LayoutFileWriter.Write(BitConverter.GetBytes(j)[3]);
                    LayoutFileWriter.Write(BitConverter.GetBytes(j)[2]);
                    LayoutFileWriter.Write(BitConverter.GetBytes(j)[1]);
                    LayoutFileWriter.Write(BitConverter.GetBytes(j)[0]);

                    long SaveCurrentPos = LayoutFileWriter.BaseStream.Position;
                    LayoutFileWriter.BaseStream.Position = 0x18000 + (0x24 * (j));

                    i.MiscSettings[0] = 1;
                    i.MiscSettings[1] = 0;
                    i.MiscSettings[2] = BitConverter.GetBytes(j)[1];
                    i.MiscSettings[3] = BitConverter.GetBytes(j)[0];

                    LayoutFileWriter.BaseStream.Position = 0x18000 + (0x24 * j);
                    LayoutFileWriter.Write(i.MiscSettings, 0, 36);

                    j++;

                    LayoutFileWriter.BaseStream.Position = SaveCurrentPos;
                }
                else
                    LayoutFileWriter.Write(0);
            }
            LayoutFileWriter.Close();
        }

        public void EnableAllEditors()
        {
            ComboBoxList.Enabled = true;
            ComboBoxObjectPicker.Enabled = true;
            NumericObjLink.Enabled = true;
            NumericObjRend.Enabled = true;
            NumericPosX.Enabled = true;
            NumericPosY.Enabled = true;
            NumericPosZ.Enabled = true;
            NumericRotX.Enabled = true;
            NumericRotY.Enabled = true;
            NumericRotZ.Enabled = true;
            ButtonGetSpeed.Enabled = true;
            ButtonGetFly.Enabled = true;
            ButtonGetPow.Enabled = true;
            ButtonSpeedRot.Enabled = true;
            ButtonFlyRot.Enabled = true;
            ButtonPowRot.Enabled = true;
            ButtonTeleport.Enabled = true;
            GroupBoxGetPos.Enabled = true;
            GroupBoxGetRot.Enabled = true;
        }

        public void DisableAllEditors()
        {
            ComboBoxList.Enabled = false;
            ComboBoxObjectPicker.Enabled = false;
            NumericObjLink.Enabled = false;
            NumericObjRend.Enabled = false;
            NumericPosX.Enabled = false;
            NumericPosY.Enabled = false;
            NumericPosZ.Enabled = false;
            NumericRotX.Enabled = false;
            NumericRotY.Enabled = false;
            NumericRotZ.Enabled = false;
            ButtonGetSpeed.Enabled = false;
            ButtonGetFly.Enabled = false;
            ButtonGetPow.Enabled = false;
            ButtonSpeedRot.Enabled = false;
            ButtonFlyRot.Enabled = false;
            ButtonPowRot.Enabled = false;
            ButtonTeleport.Enabled = false;
            GroupBoxGetPos.Enabled = false;
            GroupBoxGetRot.Enabled = false;
        }

        private void ButtonFindNextLink_Click(object sender, EventArgs e)
        {
            if (SETObjectList.Count < 2)
                return;

            if (SelectedObject != SETObjectList.Count - 1)
                for (int i = SelectedObject + 1; i < SETObjectList.Count; i++)
                    if (SETObjectList[i].Link == SETObjectList[SelectedObject].Link)
                    {
                        ListBoxObjects.SelectedIndex = i;
                        return;
                    }
            if (SelectedObject > 0)
                for (int i = 0; i < SelectedObject; i++)
                    if (SETObjectList[i].Link == SETObjectList[SelectedObject].Link)
                    {
                        ListBoxObjects.SelectedIndex = i;
                        return;
                    }

            MessageBox.Show("No other object has this same Link ID!");
        }

        //Now let's edit the objects!

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            SETObjectList.Add(new SETObject());
            SETObjectList[SETObjectList.Count - 1].FindName();
            ListBoxObjects.Items.Add(SETObjectList[SETObjectList.Count - 1].GetName());
            ListBoxObjects.SelectedIndex = SETObjectList.Count - 1;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (SelectedObject != -1)
            {
                int Temp = SelectedObject;
                ListBoxObjects.Items.RemoveAt(Temp);
                SETObjectList.RemoveAt(Temp);
                if (Temp < SETObjectList.Count)
                    ListBoxObjects.SelectedIndex = Temp;
                else
                    ListBoxObjects.SelectedIndex = Temp - 1;
            }
        }

        private void ListBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProgramIsChangingStuff = true;
            foreach (SETObject i in SETObjectList)
                i.isSelected = false;
            SelectedObject = ListBoxObjects.SelectedIndex;

            if (SelectedObject == -1)
                DisableAllEditors();
            else
            {
                EnableAllEditors();

                for (int i = 0; i < ComboBoxList.Items.Count; i++)
                    if (Convert.ToByte(ComboBoxList.Items[i].ToString().Substring(0, 2), 16) == SETObjectList[SelectedObject].List)
                    {
                        ComboBoxList.SelectedIndex = i;
                        break;
                    }

                FillObjectPickerFromList(SETObjectList[SelectedObject].List);
                for (int i = 0; i < ComboBoxObjectPicker.Items.Count; i++)
                    if ((ComboBoxObjectPicker.Items[i] as ObjectEntry).Type == SETObjectList[SelectedObject].Type)
                    {
                        ComboBoxObjectPicker.SelectedIndex = i;
                        break;
                    }

                SETObjectList[SelectedObject].isSelected = true;

                NumericPosX.Value = (decimal)(SETObjectList[SelectedObject].X);
                NumericPosY.Value = (decimal)(SETObjectList[SelectedObject].Y);
                NumericPosZ.Value = (decimal)(SETObjectList[SelectedObject].Z);
                NumericRotX.Value = (decimal)(SETObjectList[SelectedObject].XRot * 360f / 65536f);
                NumericRotY.Value = (decimal)(SETObjectList[SelectedObject].YRot * 360f / 65536f);
                NumericRotZ.Value = (decimal)(SETObjectList[SelectedObject].ZRot * 360f / 65536f);
                NumericObjLink.Value = SETObjectList[SelectedObject].Link;
                NumericObjRend.Value = SETObjectList[SelectedObject].RendDist;
                checkBoxMiscSettings.Checked = SETObjectList[SelectedObject].HasMiscID;
                MiscSettingPicker(SETObjectList[SelectedObject].List, SETObjectList[SelectedObject].Type);
            }
            ProgramIsChangingStuff = false;

            TextBoxNumOfObjects.Text = (SelectedObject + 1).ToString() + "/" + SETObjectList.Count.ToString() + " objects";
        }

        public void FillObjectPickerFromList(byte List)
        {
            ComboBoxObjectPicker.Items.Clear();

            foreach (ObjectEntry i in ObjectEntryStream)
                if (i.List == List)
                    ComboBoxObjectPicker.Items.Add(i);
        }

        private void ComboBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
            {
                SETObjectList[SelectedObject].List = Convert.ToByte(ComboBoxList.SelectedItem.ToString().Substring(0, 2), 16);
                SETObjectList[SelectedObject].FindName();
                FillObjectPickerFromList(SETObjectList[SelectedObject].List);
                ListBoxObjects.Items[SelectedObject] = SETObjectList[SelectedObject].GetName();
            }
        }

        private void ComboBoxObjectPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
            {
                SETObjectList[SelectedObject].Type = (ComboBoxObjectPicker.SelectedItem as ObjectEntry).Type;
                SETObjectList[SelectedObject].FindName();
                ListBoxObjects.Items[SelectedObject] = SETObjectList[SelectedObject].GetName();
            }
        }

        private void NumericPosX_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].X = (float)NumericPosX.Value;
        }

        private void NumericPosY_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].Y = (float)NumericPosY.Value;
        }

        private void NumericPosZ_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].Z = (float)NumericPosZ.Value;
        }

        private void NumericRotX_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].XRot = (int)((float)NumericRotX.Value * (65536f / 360f));
        }

        private void NumericRotY_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].YRot = (int)((float)NumericRotY.Value * (65536f / 360f));
        }

        private void NumericRotZ_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].ZRot = (int)((float)NumericRotZ.Value * (65536f / 360f));
        }

        private void NumericObjLink_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
            {
                SETObjectList[SelectedObject].Link = (byte)NumericObjLink.Value;
                SETObjectList[SelectedObject].FindName();
                ListBoxObjects.Items[SelectedObject] = SETObjectList[SelectedObject].GetName();
            }
        }

        private void NumericObjRend_ValueChanged(object sender, EventArgs e)
        {
            if (!ProgramIsChangingStuff)
                SETObjectList[SelectedObject].Link = (byte)NumericObjRend.Value;
        }

        //This is the place where we get stuff from ingame

        public ReadWriteProcess MemManager = new ReadWriteProcess();
        public IntPtr Pointer0X;
        public IntPtr Pointer0Y;
        public IntPtr Pointer0Z;
        IntPtr Pointer1X;
        IntPtr Pointer1Y;
        IntPtr Pointer1Z;
        IntPtr Pointer2X;
        IntPtr Pointer2Y;
        IntPtr Pointer2Z;
        IntPtr Pointer0RX;
        IntPtr Pointer0RY;
        IntPtr Pointer0RZ;
        IntPtr Pointer1RX;
        IntPtr Pointer1RY;
        IntPtr Pointer1RZ;
        IntPtr Pointer2RX;
        IntPtr Pointer2RY;
        IntPtr Pointer2RZ;
        
        public void DetermineForm0Pointers()
        {
            MemManager.TryAttachToProcess("SONIC HEROES(TM)");
            Pointer0X = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x28);
            Pointer0Y = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x2c);
            Pointer0Z = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x30);
            Pointer0RX = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x34);
            Pointer0RY = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x38);
            Pointer0RZ = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce820))) + 0x398) + 0x3c);
        }

        public void DetermineForm1Pointers()
        {
            MemManager.TryAttachToProcess("SONIC HEROES(TM)");
            Pointer1X = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x28);
            Pointer1Y = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x2c);
            Pointer1Z = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x30);
            Pointer1RX = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x34);
            Pointer1RY = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x38);
            Pointer1RZ = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce824))) + 0x398) + 0x3c);
        }

        public void DetermineForm2Pointers()
        {
            MemManager.TryAttachToProcess("SONIC HEROES(TM)");
            Pointer2X = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x28);
            Pointer2Y = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x2c);
            Pointer2Z = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x30);
            Pointer2RX = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x34);
            Pointer2RY = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x38);
            Pointer2RZ = new IntPtr(MemManager.ReadUInt32(new IntPtr(MemManager.ReadUInt32(new IntPtr(0x400000 + 0x5ce828))) + 0x398) + 0x3c);
        }

        private void ButtonGetSpeed_Click(object sender, EventArgs e)
        {
            DetermineForm0Pointers();
            if (ProcessIsAttached)
            {
                NumericPosX.Value = (decimal)MemManager.ReadFloat(Pointer0X);
                NumericPosY.Value = (decimal)MemManager.ReadFloat(Pointer0Y);
                NumericPosZ.Value = (decimal)MemManager.ReadFloat(Pointer0Z);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonGetFly_Click(object sender, EventArgs e)
        {
            DetermineForm1Pointers();
            if (ProcessIsAttached)
            {
                NumericPosX.Value = (decimal)MemManager.ReadFloat(Pointer1X);
                NumericPosY.Value = (decimal)MemManager.ReadFloat(Pointer1Y);
                NumericPosZ.Value = (decimal)MemManager.ReadFloat(Pointer1Z);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonGetPow_Click(object sender, EventArgs e)
        {
            DetermineForm2Pointers();
            if (ProcessIsAttached)
            {
                NumericPosX.Value = (decimal)MemManager.ReadFloat(Pointer2X);
                NumericPosY.Value = (decimal)MemManager.ReadFloat(Pointer2Y);
                NumericPosZ.Value = (decimal)MemManager.ReadFloat(Pointer2Z);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonSpeedRot_Click(object sender, EventArgs e)
        {
            DetermineForm0Pointers();
            if (ProcessIsAttached)
            {
                NumericRotX.Value = (decimal)MemManager.ReadUInt32(Pointer0RX) * (180 / 32768);
                NumericRotY.Value = (decimal)MemManager.ReadUInt32(Pointer0RY) * (180 / 32768);
                NumericRotZ.Value = (decimal)MemManager.ReadUInt32(Pointer0RZ) * (180 / 32768);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonFlyRot_Click(object sender, EventArgs e)
        {
            DetermineForm1Pointers();
            if (ProcessIsAttached)
            {
                NumericRotX.Value = (decimal)MemManager.ReadUInt32(Pointer1RX) * (180 / 32768);
                NumericRotY.Value = (decimal)MemManager.ReadUInt32(Pointer1RY) * (180 / 32768);
                NumericRotZ.Value = (decimal)MemManager.ReadUInt32(Pointer1RZ) * (180 / 32768);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonPowRot_Click(object sender, EventArgs e)
        {
            DetermineForm2Pointers();
            if (ProcessIsAttached)
            {
                NumericRotX.Value = (decimal)MemManager.ReadUInt32(Pointer2RX) * (180 / 32768);
                NumericRotY.Value = (decimal)MemManager.ReadUInt32(Pointer2RY) * (180 / 32768);
                NumericRotZ.Value = (decimal)MemManager.ReadUInt32(Pointer2RZ) * (180 / 32768);
            }
            else MessageBox.Show("Error collecting data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonTeleport_Click(object sender, EventArgs e)
        {
            MemManager.TryAttachToProcess("SONIC HEROES(TM)");
            DetermineForm0Pointers();
            DetermineForm1Pointers();
            DetermineForm2Pointers();
            if (ProcessIsAttached)
            {
                MemManager.Write4bytes(Pointer0X, BitConverter.GetBytes((float)NumericPosX.Value));
                MemManager.Write4bytes(Pointer0Y, BitConverter.GetBytes((float)NumericPosY.Value));
                MemManager.Write4bytes(Pointer0Z, BitConverter.GetBytes((float)NumericPosZ.Value));
                MemManager.Write4bytes(Pointer1X, BitConverter.GetBytes((float)NumericPosX.Value));
                MemManager.Write4bytes(Pointer1Y, BitConverter.GetBytes((float)NumericPosY.Value));
                MemManager.Write4bytes(Pointer1Z, BitConverter.GetBytes((float)NumericPosZ.Value));
                MemManager.Write4bytes(Pointer2X, BitConverter.GetBytes((float)NumericPosX.Value));
                MemManager.Write4bytes(Pointer2Y, BitConverter.GetBytes((float)NumericPosY.Value));
                MemManager.Write4bytes(Pointer2Z, BitConverter.GetBytes((float)NumericPosZ.Value));
            }
            else MessageBox.Show("Error writing data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MiscSettingPicker(byte ObjectList, byte ObjectType)
        {
            PropertyGridMisc.SelectedObject = null;
            if (SETObjectList[SelectedObject].HasMiscID == false)
                return;

            switch (ObjectList)
            {
                case 0:
                    //General
                    switch (ObjectType)
                    {
                        case 0:
                        case 0x1b:
                        case 0x20:
                        case 0x21:
                        case 0x22:
                        case 0x67:
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        case 0x1:
                            PropertyGridMisc.SelectedObject = new Object0001_Spring();
                            break;
                        case 0x2:
                            PropertyGridMisc.SelectedObject = new Object0002_3Spring();
                            break;
                        case 0x3:
                            PropertyGridMisc.SelectedObject = new Object0003_Ring();
                            break;
                        case 0x4:
                            PropertyGridMisc.SelectedObject = new Object0004_HintRing();
                            break;
                        case 0x5:
                            PropertyGridMisc.SelectedObject = new Object0005_Switch();
                            break;
                        case 0x6:
                            PropertyGridMisc.SelectedObject = new Object0006_SwitchPP();
                            break;
                        case 0x7:
                            PropertyGridMisc.SelectedObject = new Object0007_Target();
                            break;
                        case 0xb:
                        case 0xc:
                            PropertyGridMisc.SelectedObject = new Object_DashPadRing();
                            break;
                        case 0xd:
                            PropertyGridMisc.SelectedObject = new Object000D_BigRings();
                            break;
                        case 0xe:
                            PropertyGridMisc.SelectedObject = new Object000E_Checkpoint();
                            break;
                        case 0xf:
                            PropertyGridMisc.SelectedObject = new Object000F_DashRamp();
                            break;
                        //Case &H10
                        //PropertyGridMisc.SelectedObject = New Object0010_Cannon
                        //Case &H13
                        //PropertyGridMisc.SelectedObject = New Object0013_Weight
                        //Case &H14
                        //PropertyGridMisc.SelectedObject = New Object0014_WeightBreak
                        case 0x15:
                            PropertyGridMisc.SelectedObject = new Object0015_SpikeBall();
                            break;
                        //Case &H16
                        //PropertyGridMisc.SelectedObject = New Object0016_LaserFence
                        case 0x18:
                            PropertyGridMisc.SelectedObject = new Object0018_ItemBox();
                            break;
                        case 0x19:
                            PropertyGridMisc.SelectedObject = new Object0019_ItemBalloon();
                            break;
                        case 0x1d:
                            PropertyGridMisc.SelectedObject = new Object001D_Pulley();
                            break;
                        case 0x23:
                            PropertyGridMisc.SelectedObject = new Object0023_Chao();
                            break;
                        //Case &H24
                        //PropertyGridMisc.SelectedObject = New Object0024_Cage
                        case 0x25:
                            PropertyGridMisc.SelectedObject = new Object0025_FormSign();
                            break;
                        case 0x26:
                            PropertyGridMisc.SelectedObject = new Object0026_FormGate();
                            break;
                        //Case &H28
                        //PropertyGridMisc.SelectedObject = New Object0028_Propeller
                        //Case &H29
                        //PropertyGridMisc.SelectedObject = New Object0029_Pole
                        //Case &H2C
                        //PropertyGridMisc.SelectedObject = New Object002C_Gong
                        case 0x2e:
                            PropertyGridMisc.SelectedObject = new Object002E_Fan();
                            break;
                        case 0x31:
                            PropertyGridMisc.SelectedObject = new Object0031_Case();
                            break;
                        case 0x32:
                            PropertyGridMisc.SelectedObject = new Object0032_WarpFlower();
                            break;
                        //Case &H50
                        //PropertyGridMisc.SelectedObject = New Object0050_SetCollision
                        case 0x56:
                            PropertyGridMisc.SelectedObject = new Object0056_TriggerTalk();
                            break;
                        //Case &H59
                        //PropertyGridMisc.SelectedObject = New Object0059_TriggerLight
                        //Case &H60
                        //PropertyGridMisc.SelectedObject = New Object0060
                        //Case &H61
                        //PropertyGridMisc.SelectedObject = New Object0061
                        //Case &H62
                        //PropertyGridMisc.SelectedObject = New Object0062
                        //Case &H63
                        //PropertyGridMisc.SelectedObject = New Object0063
                        //Case &H64
                        //PropertyGridMisc.SelectedObject = New Object0064
                        //Case &H65
                        //PropertyGridMisc.SelectedObject = New Object0065
                        //Case &H66
                        //PropertyGridMisc.SelectedObject = New Object0066
                        case 0x80:
                            PropertyGridMisc.SelectedObject = new Object0080_TriggerTeleport();
                            break;
                        //Case &H81
                        //PropertyGridMisc.SelectedObject = New Object0081
                        //Case &H82
                        //PropertyGridMisc.SelectedObject = New Object0082
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 1:
                    //Seaside Hill
                    switch (ObjectType)
                    {
                        case 0x2:
                            PropertyGridMisc.SelectedObject = new Object0102_TruckRail();
                            break;
                        case 0x3:
                            PropertyGridMisc.SelectedObject = new Object0103_TruckPath();
                            break;
                        case 0x4:
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        case 0x5:
                            PropertyGridMisc.SelectedObject = new Object0105_MovingRuin();
                            break;
                        case 0x8:
                            PropertyGridMisc.SelectedObject = new Object0108_TriggerRuins();
                            break;
                        case 0xa:
                            PropertyGridMisc.SelectedObject = new Object010A_Sun();
                            break;
                        case 0xb:
                            PropertyGridMisc.SelectedObject = new Object0023_Chao();
                            break;
                        case 0x80:
                            PropertyGridMisc.SelectedObject = new Object0180_FlowerPatch();
                            break;
                        //Case &H81
                        //PropertyGridMisc.SelectedObject = New Object0181_SeaPole
                        case 0x82:
                            PropertyGridMisc.SelectedObject = new Object0182_Whale();
                            break;
                        case 0x83:
                            PropertyGridMisc.SelectedObject = new Object0183_Seagulls();
                            break;
                        case 0x84:
                            PropertyGridMisc.SelectedObject = new Object0184_LargeBird();
                            break;
                        //Case &H86
                        //PropertyGridMisc.SelectedObject = New Object0186_WaterfallLarge
                        case 0x87:
                            PropertyGridMisc.SelectedObject = new Object0187_Tides();
                            break;
                        case 0x88:
                            PropertyGridMisc.SelectedObject = new Object0188_SmallStonePlatform();
                            break;
                        //Case &H89
                        //PropertyGridMisc.SelectedObject = New Object0186_WaterfallSmall
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 2:
                    //Ocean Palace
                    switch (ObjectType)
                    {
                        case 0:
                            PropertyGridMisc.SelectedObject = new Object0200_CrumbleStonePillar();
                            break;
                        case 0x2:
                            PropertyGridMisc.SelectedObject = new Object0202_BreakDoor();
                            break;
                        case 0x3:
                            //Small block
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        case 0x4:
                            PropertyGridMisc.SelectedObject = new Object0204_Kaos();
                            break;
                        case 0xc:
                            PropertyGridMisc.SelectedObject = new Object020C_TriggerKaos();
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 3:
                    //Grand Metropolis
                    switch (ObjectType)
                    {
                        case 0:
                            PropertyGridMisc.SelectedObject = new Object0300_AcceleratorRoad();
                            break;
                        case 0x2:
                            PropertyGridMisc.SelectedObject = new Object0302_RoadCap();
                            break;
                        case 0x3:
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        case 0x4:
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        case 0x5:
                            PropertyGridMisc.SelectedObject = new Object0305_BigBridge();
                            break;
                        case 0x7:
                            PropertyGridMisc.SelectedObject = new Object0307_Blimp();
                            break;
                        case 0x8:
                            PropertyGridMisc.SelectedObject = new Object0308_Accelerator();
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 4:
                    //Power Plant
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 5:
                    //Casino Park
                    switch (ObjectType)
                    {
                        case 0x87:
                            PropertyGridMisc.SelectedObject = new Object0587_GiantCasinoChip();
                            break;
                        case 0x88:
                            PropertyGridMisc.SelectedObject = null;
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 7:
                    //Rail Canyon
                    switch (ObjectType)
                    {
                        case 3:
                            PropertyGridMisc.SelectedObject = new Object0703_RailBooster();
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 8:
                    //Bullet Station
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 9:
                    //Frog Forest
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x11:
                    //Hang Castle
                    switch (ObjectType)
                    {
                        case 0x0:
                            PropertyGridMisc.SelectedObject = new Object1100_TeleportSwitch();
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x13:
                    //Egg Fleet
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x14:
                    //Final Fortress
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x15:
                    //Enemy/Special
                    switch (ObjectType)
                    {
                        case 0:
                            PropertyGridMisc.SelectedObject = new Object1500_EggFlapper();
                            break;
                        case 0x10:
                            PropertyGridMisc.SelectedObject = new Object1510_EggPawn();
                            break;
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x16:
                    //Egg Emperor
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x20:
                    //Egg Fleet
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x23:
                    //Egg Albatross
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0x33:
                    //Bobsled Race
                    switch (ObjectType)
                    {
                        default:
                            PropertyGridMisc.SelectedObject = new Object_Default();
                            break;
                    }
                    break;
                case 0xff:
                    //System
                    PropertyGridMisc.SelectedObject = new Object_Default();
                    break;
                default:
                    //Are there even other lists
                    PropertyGridMisc.SelectedObject = new Object_Default();
                    break;
            }
        }

        public class ReadWriteProcess
        {
            [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern IntPtr OpenProcess(UInt32 dwDesiredAcess, bool bInheritHandle, Int32 dwProcessId);
            [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesRead);
            [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int iSize, int lpNumberOfBytesWritten);
            [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
            private static extern bool CloseHandle(IntPtr hObject);

            const int PROCESS_WM_READ = 0x0010;

            //to keep track of it. not used yet.
            private Process targetProcess = null;
            //Used for ReadProcessMemory
            private IntPtr targetProcessHandle = IntPtr.Zero;
            private UInt32 PROCESS_ALL_ACCESS = 0x1f0fff;

            private UInt32 PROCESS_VM_READ = 0x10;
            public bool TryAttachToProcess(string windowCaption)
            {
                Process[] _allProcesses = Process.GetProcesses();
                foreach (Process pp in _allProcesses)
                {
                    if (pp.MainWindowTitle.ToLower().Contains(windowCaption.ToLower()))
                    {
                        //found it! proceed.
                        return TryAttachToProcess(pp);
                    }
                }
                ProcessIsAttached = false;
                return false;
            }

            public bool TryAttachToProcess(Process proc)
            {
                bool functionReturnValue = false;
                DetachFromProcess();
                //not already attached
                if (targetProcessHandle == IntPtr.Zero)
                {
                    targetProcess = proc;
                    targetProcessHandle = OpenProcess(PROCESS_ALL_ACCESS, false, targetProcess.Id);
                    if (targetProcessHandle == IntPtr.Zero)
                    {
                        functionReturnValue = false;
                        ProcessIsAttached = false;
                    }
                    else
                    {
                        //if we get here, all connected and ready to use ReadProcessMemory()
                        functionReturnValue = true;
                        ProcessIsAttached = true;
                    }
                    //already attached
                }
                else
                {
                    functionReturnValue = false;
                }
                return functionReturnValue;
            }

            public void DetachFromProcess()
            {
                if (!(targetProcessHandle == IntPtr.Zero))
                {
                    targetProcess = null;
                    try
                    {
                        CloseHandle(targetProcessHandle);
                        targetProcessHandle = IntPtr.Zero;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("MemoryManager::DetachFromProcess::CloseHandle error " + Environment.NewLine + ex.Message);
                    }
                }
            }
            
            public float ReadFloat(IntPtr addr)
            {
                byte[] rtnBytes = new byte[4];
                ReadProcessMemory(targetProcessHandle, addr, rtnBytes, 4, 0);
                return BitConverter.ToSingle(rtnBytes, 0);
            }

            public UInt16 ReadUInt16(IntPtr addr)
            {
                byte[] _rtnBytes = new byte[2];
                ReadProcessMemory(targetProcessHandle, addr, _rtnBytes, 2, 0);
                return BitConverter.ToUInt16(_rtnBytes, 0);
            }

            public UInt32 ReadUInt32(IntPtr addr)
            {
                byte[] _rtnBytes = new byte[4];
                ReadProcessMemory(targetProcessHandle, addr, _rtnBytes, 4, 0);
                return BitConverter.ToUInt32(_rtnBytes, 0);
            }

            public byte ReadByte(IntPtr addr)
            {
                byte[] _rtnByte = new byte[1];
                ReadProcessMemory(targetProcessHandle, addr, _rtnByte, 1, 0);
                return _rtnByte[0];
            }

            public void Write4bytes(IntPtr addr, byte[] vll)
            {
                WriteProcessMemory(targetProcessHandle, addr, vll, 4, 0);
            }
        }
    }
}