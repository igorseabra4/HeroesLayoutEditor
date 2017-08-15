using System;
using System.Windows.Forms;

//Class picker for misc. settings.

namespace HeroesLayoutEditor
{
    public partial class Form1 : Form
    {
        public static float ReadWriteSingle(int j)
        {
            return BitConverter.ToSingle(new byte[]{
                ((SETObjectList[SelectedObject])).MiscSettings[j + 3],
                ((SETObjectList[SelectedObject])).MiscSettings[j + 2],
                ((SETObjectList[SelectedObject])).MiscSettings[j + 1],
                ((SETObjectList[SelectedObject])).MiscSettings[j]
            }, 0);
        }

        public static void ReadWriteSingle(int j, float value)
        {
            ((SETObjectList[SelectedObject])).MiscSettings[j] = BitConverter.GetBytes(value)[3];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 1] = BitConverter.GetBytes(value)[2];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 2] = BitConverter.GetBytes(value)[1];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 3] = BitConverter.GetBytes(value)[0];
        }

        public static void ReadWriteWord(int j, UInt16 value)
        {
            ((SETObjectList[SelectedObject])).MiscSettings[j] = BitConverter.GetBytes(value)[1];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 1] = BitConverter.GetBytes(value)[0];
        }

        public static void ReadWriteWord(int j, Int16 value)
        {
            ((SETObjectList[SelectedObject])).MiscSettings[j] = BitConverter.GetBytes(value)[1];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 1] = BitConverter.GetBytes(value)[0];
        }

        public static Int16 ReadWriteWord(int j)
        {
            return BitConverter.ToInt16(new byte[]{
                ((SETObjectList[SelectedObject])).MiscSettings[j + 1],
                ((SETObjectList[SelectedObject])).MiscSettings[j]
            }, 0);
        }

        public static byte ReadWriteByte(int j)
        {
            return ((SETObjectList[SelectedObject])).MiscSettings[j];
        }

        public static void ReadWriteByte(int j, byte value)
        {
            ((SETObjectList[SelectedObject])).MiscSettings[j] = value;
        }

        public static UInt32 ReadWriteLong(int j)
        {
            return BitConverter.ToUInt32(new byte[]{
                ((SETObjectList[SelectedObject])).MiscSettings[j + 3],
                ((SETObjectList[SelectedObject])).MiscSettings[j + 2],
                ((SETObjectList[SelectedObject])).MiscSettings[j + 1],
                ((SETObjectList[SelectedObject])).MiscSettings[j]

            }, 0);
        }

        public static void ReadWriteLong(int j, UInt32 value)
        {
            ((SETObjectList[SelectedObject])).MiscSettings[j] = BitConverter.GetBytes(value)[3];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 1] = BitConverter.GetBytes(value)[2];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 2] = BitConverter.GetBytes(value)[1];
            ((SETObjectList[SelectedObject])).MiscSettings[j + 3] = BitConverter.GetBytes(value)[0];
        }

        public class Object_Default
        {
            public float F1
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float F2
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float F3
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float F4
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public float F5
            {
                get { return ReadWriteSingle(20); }
                set { ReadWriteSingle(20, value); }
            }

            public float F6
            {
                get { return ReadWriteSingle(24); }
                set { ReadWriteSingle(24, value); }
            }

            public float F7
            {
                get { return ReadWriteSingle(28); }
                set { ReadWriteSingle(28, value); }
            }

            public float F8
            {
                get { return ReadWriteSingle(32); }
                set { ReadWriteSingle(32, value); }
            }

            public Int16 W1_1
            {
                get { return ReadWriteWord(4); }
                set { ReadWriteWord(4, value); }
            }

            public Int16 W1_2
            {
                get { return ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public Int16 W2_1
            {
                get { return ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }

            public Int16 W2_2
            {
                get { return ReadWriteWord(10); }
                set { ReadWriteWord(10, value); }
            }

            public Int16 W3_1
            {
                get { return ReadWriteWord(12); }
                set { ReadWriteWord(12, value); }
            }

            public Int16 W3_2
            {
                get { return ReadWriteWord(14); }
                set { ReadWriteWord(14, value); }
            }

            public Int16 W4_1
            {
                get { return ReadWriteWord(16); }
                set { ReadWriteWord(16, value); }
            }

            public Int16 W4_2
            {
                get { return ReadWriteWord(18); }
                set { ReadWriteWord(18, value); }
            }

            public Int16 W5_1
            {
                get { return ReadWriteWord(20); }
                set { ReadWriteWord(20, value); }
            }

            public Int16 W5_2
            {
                get { return ReadWriteWord(22); }
                set { ReadWriteWord(22, value); }
            }

            public Int16 W6_1
            {
                get { return ReadWriteWord(24); }
                set { ReadWriteWord(24, value); }
            }

            public Int16 W6_2
            {
                get { return ReadWriteWord(26); }
                set { ReadWriteWord(26, value); }
            }

            public Int16 W7_1
            {
                get { return ReadWriteWord(28); }
                set { ReadWriteWord(28, value); }
            }

            public Int16 W7_2
            {
                get { return ReadWriteWord(30); }
                set { ReadWriteWord(30, value); }
            }

            public Int16 W8_1
            {
                get { return ReadWriteWord(32); }
                set { ReadWriteWord(32, value); }
            }

            public Int16 W8_2
            {
                get { return ReadWriteWord(34); }
                set { ReadWriteWord(34, value); }
            }

            public byte B1_1
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public byte B1_2
            {
                get { return ReadWriteByte(5); }
                set { ReadWriteByte(5, value); }
            }

            public byte B1_3
            {
                get { return ReadWriteByte(6); }
                set { ReadWriteByte(6, value); }
            }

            public byte B1_4
            {
                get { return ReadWriteByte(7); }
                set { ReadWriteByte(7, value); }
            }

            public byte B2_1
            {
                get { return ReadWriteByte(8); }
                set { ReadWriteByte(8, value); }
            }

            public byte B2_2
            {
                get { return ReadWriteByte(9); }
                set { ReadWriteByte(9, value); }
            }

            public byte B2_3
            {
                get { return ReadWriteByte(10); }
                set { ReadWriteByte(10, value); }
            }

            public byte B2_4
            {
                get { return ReadWriteByte(11); }
                set { ReadWriteByte(11, value); }
            }

            public byte B3_1
            {
                get { return ReadWriteByte(12); }
                set { ReadWriteByte(12, value); }
            }

            public byte B3_2
            {
                get { return ReadWriteByte(13); }
                set { ReadWriteByte(13, value); }
            }

            public byte B3_3
            {
                get { return ReadWriteByte(14); }
                set { ReadWriteByte(14, value); }
            }

            public byte B3_4
            {
                get { return ReadWriteByte(15); }
                set { ReadWriteByte(15, value); }
            }

            public byte B4_1
            {
                get { return ReadWriteByte(16); }
                set { ReadWriteByte(16, value); }
            }

            public byte B4_2
            {
                get { return ReadWriteByte(17); }
                set { ReadWriteByte(17, value); }
            }

            public byte B4_3
            {
                get { return ReadWriteByte(18); }
                set { ReadWriteByte(18, value); }
            }

            public byte B4_4
            {
                get { return ReadWriteByte(19); }
                set { ReadWriteByte(19, value); }
            }

            public byte B5_1
            {
                get { return ReadWriteByte(20); }
                set { ReadWriteByte(20, value); }
            }

            public byte B5_2
            {
                get { return ReadWriteByte(21); }
                set { ReadWriteByte(21, value); }
            }

            public byte B5_3
            {
                get { return ReadWriteByte(22); }
                set { ReadWriteByte(22, value); }
            }

            public byte B5_4
            {
                get { return ReadWriteByte(23); }
                set { ReadWriteByte(23, value); }
            }

            public byte B6_1
            {
                get { return ReadWriteByte(24); }
                set { ReadWriteByte(24, value); }
            }

            public byte B6_2
            {
                get { return ReadWriteByte(25); }
                set { ReadWriteByte(25, value); }
            }

            public byte B6_3
            {
                get { return ReadWriteByte(26); }
                set { ReadWriteByte(26, value); }
            }

            public byte B6_4
            {
                get { return ReadWriteByte(27); }
                set { ReadWriteByte(27, value); }
            }

            public byte B7_1
            {
                get { return ReadWriteByte(28); }
                set { ReadWriteByte(28, value); }
            }

            public byte B7_2
            {
                get { return ReadWriteByte(29); }
                set { ReadWriteByte(29, value); }
            }

            public byte B7_3
            {
                get { return ReadWriteByte(30); }
                set { ReadWriteByte(30, value); }
            }

            public byte B7_4
            {
                get { return ReadWriteByte(31); }
                set { ReadWriteByte(31, value); }
            }

            public byte B8_1
            {
                get { return ReadWriteByte(32); }
                set { ReadWriteByte(32, value); }
            }

            public byte B8_2
            {
                get { return ReadWriteByte(33); }
                set { ReadWriteByte(33, value); }
            }

            public byte B8_3
            {
                get { return ReadWriteByte(34); }
                set { ReadWriteByte(34, value); }
            }

            public byte B8_4
            {
                get { return ReadWriteByte(35); }
                set { ReadWriteByte(35, value); }
            }

            public UInt32 L1
            {
                get { return ReadWriteLong(4); }
                set { ReadWriteLong(4, value); }
            }

            public UInt32 L2
            {
                get { return ReadWriteLong(8); }
                set { ReadWriteLong(8, value); }
            }

            public UInt32 L3
            {
                get { return ReadWriteLong(12); }
                set { ReadWriteLong(12, value); }
            }

            public UInt32 L4
            {
                get { return ReadWriteLong(16); }
                set { ReadWriteLong(16, value); }
            }

            public UInt32 L5
            {
                get { return ReadWriteLong(20); }
                set { ReadWriteLong(20, value); }
            }

            public UInt32 L6
            {
                get { return ReadWriteLong(24); }
                set { ReadWriteLong(24, value); }
            }

            public UInt32 L7
            {
                get { return ReadWriteLong(28); }
                set { ReadWriteLong(28, value); }
            }

            public UInt32 L8
            {
                get { return ReadWriteLong(32); }
                set { ReadWriteLong(32, value); }
            }
        }

        public enum ItemType : byte
        {
            None = 0,
            Rings5 = 1,
            Rings10 = 2,
            Rings20 = 3,
            Barrier = 4,
            ExtraLife = 5,
            SpeedUp = 6,
            TeamBlast = 7,
            Invincibility = 8,
            LevelUpSpeed = 9,
            LevelUpFly = 10,
            LevelUpPower = 11,
            RefillFlightGauge = 12
        }

        public class Object0001_Spring
        {
            public float Power
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public UInt16 ControlTime
            {
                get { return (ushort)ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }
        }

        public class Object0002_3Spring
        {
            public float Power
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public UInt16 ControlTime
            {
                get { return (ushort)ReadWriteWord(12); }
                set { ReadWriteWord(12, value); }
            }

            public ItemType Item
            {
                get { return (ItemType)ReadWriteByte(14); }
                set
                {
                    byte a = (byte)value; ReadWriteByte(14, a);
                }
            }
        }

        public class Object0003_Ring
        {
            public enum RingTypes : short
            {
                Normal = 0,
                Line = 1,
                Circle = 2,
                Arch = 3
            }

            public RingTypes Type
            {
                get { return (RingTypes)ReadWriteWord(4); }
                set
                {
                    ushort a = (ushort)value;
                    ReadWriteWord(4, a);
                }
            }

            public UInt16 NumberOfRings
            {
                get { return (ushort)ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public float TotalLenght
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Radius
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0004_HintRing
        {
            public UInt16 LineToPlay
            {
                get { return (ushort)ReadWriteWord(4); }
                set { ReadWriteWord(4, value); }
            }
        }

        public class Object0005_Switch
        {
            public enum SwitchType : byte
            {
                Alternate = 0,
                Touch = 1,
                Once = 2,
                Interlock = 3
            }

            public SwitchType Type
            {
                get { return (SwitchType)ReadWriteByte(4); }
                set
                {
                    byte a = (byte)value; ReadWriteByte(4, a);
                }
            }

            public UInt16 Unknown
            {
                get { return (ushort)ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }
        }

        public class Object0006_SwitchPP
        {
            public enum SwitchMode : byte
            {
                PushToTurnOn = 0,
                PullToTurnOn = 1
            }

            public SwitchMode Mode
            {
                get { return (SwitchMode)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }
        }

        public class Object0007_Target
        {
            public ItemType Item
            {
                get { return (ItemType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public byte AppearMode
            {
                get { return ReadWriteByte(5); }
                set { ReadWriteByte(5, value); }
            }

            public byte LinkID
            {
                get { return ReadWriteByte(6); }
                set { ReadWriteByte(6, value); }
            }
        }

        public class Object_DashPadRing
        {
            public float Speed
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public UInt16 ControlTime
            {
                get { return (ushort)ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }
        }

        public class Object000D_BigRings
        {
            public enum RainbowType : UInt16
            {
                Speed = 0,
                FlyA = 1,
                FlyB = 2,
                PowerS = 3,
                PowerL = 4
            }

            public RainbowType Type
            {
                get { return (RainbowType)ReadWriteWord(4); }
                set
                {
                    ushort a = (ushort)value; ReadWriteWord(4, a);
                }
            }

            public UInt16 AdditionalControlTime
            {
                get { return (ushort)ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Offset
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

        }

        public class Object000E_Checkpoint
        {
            public UInt16 Priority
            {
                get { return (ushort)ReadWriteWord(4); }
                set { ReadWriteWord(4, value); }
            }
        }

        public class Object000F_DashRamp
        {
            public float SpeedHorizontal
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float SpeedVertical
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public UInt16 ControlTime
            {
                get { return (ushort)ReadWriteWord(12); }
                set { ReadWriteWord(12, value); }
            }
        }

        public class Object0015_SpikeBall
        {
            public enum SpikeBallType : UInt32
            {
                SingleBall = 0,
                DoubleBall = 1
            }

            public SpikeBallType Type
            {
                get { return (SpikeBallType)ReadWriteLong(4); }
                set { uint a = (uint)value; ReadWriteLong(4, a); }
            }

            public float RotateSpeed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0018_ItemBox
        {
            public ItemType Item
            {
                get { return (ItemType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }
        }

        public class Object0019_ItemBalloon
        {
            public ItemType Item
            {
                get { return (ItemType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object001D_Pulley
        {
            public float Elevation
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float Unknown1
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Unknown2
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public enum PulleyType : UInt16
            {
                Up = 0,
                Down = 1
            }

            public PulleyType Type
            {
                get { return (PulleyType)ReadWriteWord(16); }
                set
                {
                    ushort a = (ushort)value; ReadWriteWord(16, a);
                }
            }
        }

        public class Object0023_Chao
        {
            public float Radius
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float AngularSpeed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public enum Formations : byte
        {
            Speed = 0,
            Fly = 1,
            Power = 2
        }

        public class Object0025_FormSign
        {
            public Formations Formation
            {
                get { return (Formations)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }
        }

        public class Object0026_FormGate
        {
            public Formations Formation
            {
                get { return (Formations)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public float Width
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Height
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object002E_Fan
        {
            public float Scale
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float HeightTriangleDive
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float HeightDefault
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float Power
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public enum FanMode : byte
            {
                Normal = 0,
                Switchable = 1,
                Normal2 = 2,
                Switchable2 = 3
            }

            public FanMode Mode
            {
                get { return (FanMode)ReadWriteByte(20); }
                set { byte a = (byte)value; ReadWriteByte(20, a); }
            }

            public byte LinkID
            {
                get { return ReadWriteByte(21); }
                set { ReadWriteByte(21, value); }
            }

            public enum FanDisplay : byte
            {
                Normal = 0,
                Invisible = 1
            }

            public FanDisplay DisplayMode
            {
                get { return (FanDisplay)ReadWriteByte(28); }
                set { byte a = (byte)value; ReadWriteByte(28, a); }
            }
        }

        public class Object0031_Case
        {
            public float ScaleX
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float ScaleY
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float ScaleZ
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public byte LinkID
            {
                get { return ReadWriteByte(16); }
                set { ReadWriteByte(16, value); }
            }
        }

        public class Object0032_WarpFlower
        {
            public enum FlowerType : byte
            {
                Item = 0,
                Scaffold = 1,
                Warp = 2
            }

            public FlowerType Type
            {
                get { return (FlowerType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float RisingHeight
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0056_TriggerTalk
        {
            public enum TriggerTalkShapes : UInt16
            {
                Sphere = 0,
                Cylinder = 1,
                Rectangle = 2
            }
            public TriggerTalkShapes Shape
            {
                get { return (TriggerTalkShapes)ReadWriteWord(4); }
                set
                {
                    ushort a = (ushort)value; ReadWriteWord(4, a);
                }
            }

            public UInt16 CommonLineToPlay
            {
                get { return (ushort)ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public enum TriggerTalkTypes : UInt16
            {
                Common = 0,
                Tutorial = 1,
                EventType = 2
            }

            public TriggerTalkTypes HintType
            {
                get { return (TriggerTalkTypes)ReadWriteWord(10); }
                set
                {
                    ushort a = (ushort)value; ReadWriteWord(10, a);
                }
            }

            public float LenghtOrRadius
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float Height
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public float UnknownFloat
            {
                get { return ReadWriteSingle(20); }
                set { ReadWriteSingle(20, value); }
            }

            public UInt16 TutorialHintStart1
            {
                get { return (ushort)ReadWriteWord(24); }
                set { ReadWriteWord(24, value); }
            }

            public UInt16 TutorialHintEnd1
            {
                get { return (ushort)ReadWriteWord(26); }
                set { ReadWriteWord(26, value); }
            }

            public UInt16 TutorialHintStart2
            {
                get { return (ushort)ReadWriteWord(28); }
                set { ReadWriteWord(28, value); }
            }

            public UInt16 TutorialHintEnd2
            {
                get { return (ushort)ReadWriteWord(30); }
                set { ReadWriteWord(30, value); }
            }

            public UInt16 TutorialHintStart3
            {
                get { return (ushort)ReadWriteWord(32); }
                set { ReadWriteWord(32, value); }
            }

            public UInt16 TutorialHintEnd3
            {
                get { return (ushort)ReadWriteWord(34); }
                set { ReadWriteWord(34, value); }
            }
        }

        public class Object0080_TriggerTeleport
        {
            public float Radius
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float XDestination
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float YDestination
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float ZDestination
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }
        }

        public class Object0102_TruckRail
        {
            public byte TypeUnknown
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float Lenght
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0103_TruckPath
        {
            public UInt16 PathType
            {
                get { return (ushort)ReadWriteWord(4); }
                set { ReadWriteWord(4, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0105_MovingRuin
        {
            public enum RuinType : byte
            {
                Small = 0,
                Normal = 1,
                Special = 2
            }

            public RuinType Type
            {
                get { return (RuinType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public float MovingDistance
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0108_TriggerRuins
        {
            public float XLenght
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float YHeight
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float ZLenght
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public enum RuinType : byte
            {
                SeasideHillRuin = 0,
                OceanPalaceRuins = 1
            }

            public RuinType Type
            {
                get { return (RuinType)ReadWriteByte(16); }
                set { byte a = (byte)value; ReadWriteByte(16, a); }
            }            
        }

        public class Object010A_Sun
        {
            public byte TypeUnknown
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }
        }

        public class Object0180_FlowerPatch
        {
            public byte Type
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0182_Whale
        {
            public byte WhaleType
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public UInt16 TriggerSize
            {
                get { return (ushort)ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public float WhaleScale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float ArchRadius
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float TriggerX
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public float TriggerY
            {
                get { return ReadWriteSingle(20); }
                set { ReadWriteSingle(20, value); }
            }

            public float TriggerZ
            {
                get { return ReadWriteSingle(24); }
                set { ReadWriteSingle(24, value); }
            }
        }

        public class Object0183_Seagulls
        {
            public byte Number
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float Radius
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0184_LargeBird
        {
            public float Radius
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Scale
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0187_Tides
        {
            public byte Type
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0188_SmallStonePlatform
        {
            public float Scale
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }
        }

        public class Object0200_CrumbleStonePillar
        {
            public enum RuinType : byte
            {
                Left = 0,
                Right = 1,
                Center = 2
            }
            public RuinType Type
            {
                get { return (RuinType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }
        }

        public class Object0202_BreakDoor
        {
            public float UnknownFloat
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }
        }

        public class Object0204_Kaos
        {
            public byte KaosNumber
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float MinSpeed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float MaxSpeed
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float Acceleration
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }
        }

        public class Object020C_TriggerKaos
        {
            public float Radius
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public UInt16 KaosNumber
            {
                get { return (ushort)ReadWriteWord(8); }
                set { ReadWriteSingle(8, value); }
            }
        }

        public class Object0300_AcceleratorRoad
        {
            public byte Type
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public float Speed
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float UnknownFloat
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0302_RoadCap
        {
            public byte Unknown1
            {
                get { return ReadWriteByte(4); }
                set { ReadWriteByte(4, value); }
            }

            public Int16 Unknown2
            {
                get { return ReadWriteWord(6); }
                set { ReadWriteWord(6, value); }
            }

            public Int16 Unknown3
            {
                get { return ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }
        }

        public class Object0305_BigBridge
        {
            public float Unknown1
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float Unknown2
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float Unknown3
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float Unknown4
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }
        }

        public class Object0307_Blimp
        {
            public float XScale
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float YScale
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float ZScale
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }
        }

        public class Object0308_Accelerator
        {
            public float ProbablySpeed
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float XLenght
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float YHeight
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float ZLenght
            {
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }
        }

        public class Object0587_GiantCasinoChip
        {
            public float Scale
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public UInt32 Type
            {
                get { return ReadWriteLong(8); }
                set { ReadWriteLong(8, value); }
            }

            public UInt32 Speed
            {
                get { return ReadWriteLong(12); }
                set { ReadWriteLong(12, value); }
            }
        }

        public class Object0703_RailBooster
        {
            public float Speed
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }
        }

        public enum MysticLight : byte
        {
            StarLights = 0,
            RadialGradientLights = 1,
            SkullLightLayingDown = 2,
            SkullLightWall = 3
        }

        public class Object1100_TeleportSwitch
        {
            public float DestinationX
            {
                get { return ReadWriteSingle(4); }
                set { ReadWriteSingle(4, value); }
            }

            public float DestinationY
            {
                get { return ReadWriteSingle(8); }
                set { ReadWriteSingle(8, value); }
            }

            public float DestinationZ
            {
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public enum BallState : byte
            {
                Active = 0,
                Inactive = 1,
                ActiveSwitchBall = 2,
                ActiveSwitchBallSymbols = 3,
                WarpEffect = 4,
                Door = 5,
                Door2 = 6,
                PlatformBase = 7,
                PlatformBaseMovingPlatform = 8,
                PlatformFloor = 9,
                CrackedWall = 10,
                AnotherCrackedWall = 11,
                BrokenWallCorners = 12,
                BrokenWallCorners2 = 13,
                BrokenWallPieces = 14,
                WallPiece = 15,
                AnotherWallPiece = 16
            }
            public BallState State
            {
                get { return (BallState)ReadWriteByte(16); }
                set { byte a = (byte)value; ReadWriteByte(16, a); }
            }

            public enum BallType
            {
                Normal = 0,
                UpsideDown = 1
            }
            public BallType Type
            {
                get { return (BallType)ReadWriteByte(17); }
                set { byte a = (byte)value; ReadWriteByte(17, a); }
            }
        }

        public class Object1500_EggFlapper
        {
            public enum QualityType : byte
            {
                Normal = 0,
                Silver = 1
            }
            public QualityType Quality
            {
                get { return (QualityType)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public enum ShadowEnum : byte
            {
                Auto = 0,
                Set = 1,
                SetWithoutShadow = 2
            }
            public ShadowEnum ShadowType
            {
                get { return (ShadowEnum)ReadWriteByte(5); }
                set { byte a = (byte)value; ReadWriteByte(5, a); }
            }

            public enum MoveEnum : byte
            {
                Wait = 0,
                BackAndForth = 1,
                Wander = 2,
                Idle = 3
            }
            public MoveEnum MoveType
            {
                get { return (MoveEnum)ReadWriteByte(6); }
                set { byte a = (byte)value; ReadWriteByte(6, a); }
            }

            public enum WeaponEnum : byte
            {
                None = 0,
                Needle = 1,
                Shot = 2,
                MGun = 3,
                Laser = 4,
                Bomb = 5,
                Searchlight = 6
            }
            public WeaponEnum WeaponType
            {
                get { return (WeaponEnum)ReadWriteByte(7); }
                set { byte a = (byte)value; ReadWriteByte(7, a); }
            }

            public Int16 ScopeRange
            {
                //21
                get { return ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }

            public Int16 ScopeOffset
            {
                //22
                get { return ReadWriteWord(10); }
                set { ReadWriteWord(10, value); }
            }

            public Int16 AttackInterval
            {
                //31
                get { return ReadWriteWord(12); }
                set { ReadWriteWord(12, value); }
            }

            public Int16 AttackFrame
            {
                //31
                get { return ReadWriteWord(14); }
                set { ReadWriteWord(14, value); }
            }

            public float FLOOR
            {
                //4
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public float MoveSpeed
            {
                //5
                get { return ReadWriteSingle(20); }
                set { ReadWriteSingle(20, value); }
            }

            public float MoveRange
            {
                //6
                get
                {
                    return BitConverter.ToSingle(new byte[]{ ((SETObjectList[SelectedObject])).MiscSettings[27],
                    ((SETObjectList[SelectedObject])).MiscSettings[26],
                    ((SETObjectList[SelectedObject])).MiscSettings[25],
                    ((SETObjectList[SelectedObject])).MiscSettings[24]}, 0);
                }
                set { ReadWriteSingle(24, value); }
            }

            public float WeaponSpeed
            {
                //7
                get { return ReadWriteSingle(28); }
                set { ReadWriteSingle(28, value); }
            }

            public Int16 SearchlightAngle
            {
                //W8
                get { return ReadWriteWord(32); }
                set { ReadWriteWord(32, value); }
            }

            public Int16 SearchlightAngleX
            {
                //W8
                get { return ReadWriteWord(34); }
                set { ReadWriteWord(34, value); }
            }
        }

        public class Object1510_EggPawn
        {
            public enum StartModeEnum : byte
            {
                Asleep = 0,
                Wandering = 1,
                Running = 2,
                Fall = 3,
                Warp = 4,
                Falco = 5,
                Searching = 6
            }
            public StartModeEnum StartMode
            {
                get { return (StartModeEnum)ReadWriteByte(4); }
                set { byte a = (byte)value; ReadWriteByte(4, a); }
            }

            public enum MassTypeEnum : byte
            {
                NormalFree = 0,
                NormalStand = 1,
                KingFree = 2,
                KingStand = 3,
                Casino1Free = 4,
                Casino1Stand = 5,
                Casino2Free = 6,
                Casino2Stand = 7
            }
            public MassTypeEnum ColorMass
            {
                get { return (MassTypeEnum)ReadWriteByte(5); }
                set { byte a = (byte)value; ReadWriteByte(5, a); }
            }

            public enum WeaponTypeEnum : byte
            {
                None = 0,
                Lance = 1,
                LaserCannon = 2,
                MGun90 = 3,
                MGun120 = 4,
                MGun150 = 5,
                MGun180 = 6
            }
            public WeaponTypeEnum WeaponType
            {
                get { return (WeaponTypeEnum)ReadWriteByte(6); }
                set { byte a = (byte)value; ReadWriteByte(6, a); }
            }

            public enum ShieldTypeEnum : byte
            {
                None = 0,
                Concrete = 1,
                Plain = 2,
                Spike = 3
            }
            public ShieldTypeEnum ShieldType
            {
                get { return (ShieldTypeEnum)ReadWriteByte(7); }
                set { byte a = (byte)value; ReadWriteByte(7, a); }
            }

            public Int16 ScopeRange
            {
                //W2
                get { return ReadWriteWord(8); }
                set { ReadWriteWord(8, value); }
            }

            public Int16 ScopeOffset
            {
                //W2
                get { return ReadWriteWord(10); }
                set { ReadWriteWord(10, value); }
            }

            public float MovingRange
            {
                //F3
                get { return ReadWriteSingle(12); }
                set { ReadWriteSingle(12, value); }
            }

            public float FallWarpHeight
            {
                //F4
                get { return ReadWriteSingle(16); }
                set { ReadWriteSingle(16, value); }
            }

            public float FalcoNumberFloat
            {
                //F5
                get { return ReadWriteSingle(20); }
                set { ReadWriteSingle(20, value); }
            }

            public float ShotSpeed
            {
                //F6
                get { return ReadWriteSingle(24); }
                set { ReadWriteSingle(24, value); }
            }

            public UInt32 ShotInterval
            {
                //L7
                get { return ReadWriteLong(28); }
                set { ReadWriteLong(28, value); }
            }
        }
    }
}