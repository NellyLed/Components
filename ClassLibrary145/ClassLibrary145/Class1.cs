using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary145
{
      public class Processor
    {
        public string stamp;
        public double frequency;
        public decimal kesh;
        public int cost;
        public Processor() { }
        public Processor(double frequency) { this.frequency = frequency; }
        public Processor(string stamp) { this.stamp = stamp; }
        public Processor(decimal kesh) { this.kesh = kesh; }
        public Processor(int cost) { this.cost = cost; }

        public string Stamp
        {
            get { return stamp; }
            set
            {
                if (stamp.GetTypeCode() == TypeCode.String)
                    this.stamp = value;
            }
        }

        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (frequency.GetTypeCode() == TypeCode.Double)
                    this.frequency = value;
            }
        }
public decimal Kesh
{
    get { return kesh; }
    set
    {
        if (kesh.GetTypeCode() == TypeCode.Decimal)
            this.kesh = value;
    }
}

public int Cost
{
    get { return cost; }
    set
    {
        if (cost.GetTypeCode() == TypeCode.Int32)
            this.cost = value;
    }
}

public string StampCheck()
{
    string box1;
    box1 = String.Format("Введенное значение типа марки процессора равно {0}\n", this.Stamp);
    return box1;
}

public string FrequencyCheck()
{
    string box2;
    box2 = String.Format("Введенное значение тактовой частоты процессора равно  {0}\n", this.Frequency);
    return Convert.ToString(box2);
}

public string KeshCheck()
{
string box3;
 box3 = String.Format("Введенное значение объема КЭШа процессора равно {0}\n", this.Kesh);
return Convert.ToString(box3);
}

public string CostCheck()
  {
    string box4;
    box4 = String.Format("Введенное значение стоимости процессора равно {0}\n", this.Cost);
    return Convert.ToString(box4);
  }
}
public class MotherBoard : Processor
 {
    public double ram;
    public int core; 
    public int threads; 
    public string socket;
    public int rate; 
    public List<string> Specifications; 

public MotherBoard(string stamp, double ram, int core, int threads, string socket, int rate):base(stamp){
this.ram=ram;
this.core=core;
this.threads=threads;
this.socket=socket;
this.rate=rate;
}
    public string Socket { get { return socket; } set { this.socket = value; } }
    public int Core { get { return core; } set { this.core = value; } }
    public int Threads { get { return threads; } set { this.threads = value; } }
    public int Rate { get { return rate; } set { this.rate = value; } }
public double Ram
{
   get { return ram; }
 set {
      if (threads.GetTypeCode() == TypeCode.Double)
           this.ram = value;
    }
}
  public string Quantity(List<string> Specifications)
   {
        string s = "ОСНОВНЫЕ ХАРАКТЕРИСТИКИ ДАННОГО ТИПА ПРОЦЕССОРА";
    Specifications.Add(s);
  string s1 = "Гнездо процессора=";
   Specifications.Add(s1 + this.Socket);
string s2 = "Количество ядер=";
     Specifications.Add(s2 + this.Core);  
   string s3 = "Количество потоков=";
         Specifications.Add(s3 + Convert.ToString(this.Threads));         
        string s4 = "Разрядность вычисления процессора=";
       string s5 = "bit";
         Specifications.Add(s4 + Convert.ToString(this.Rate) + s5);
       this.Specifications = Specifications;
       return Convert.ToString(this.Specifications);
     }
      public string Volume(List<string> Specifications)
    {
        string s6 = "СПЕЦИФИКАЦИЯ ПАМЯТИ ПРОЦЕССОРА";
         string s7 = "Объем оперативной памяти=";
         string s8 = "Гб";
       Specifications.Add(s6);
         Specifications.Add(s7 + Convert.ToString(this.Ram) + s8);
       this.Specifications = Specifications;
        return Convert.ToString(this.Specifications);
     }
 }
 public class Computer : Processor
  {
  public int harddrive; 
    public int videocard; 
    public int soundadapter; 
    public int networkadapter;
public int powersupply;
public int floppydrive;
public int systemunit;
public int monitor;
public int motherboard;
public int ram1;
public int work;
List<int> Components;

public Computer(int cost, int motherboard, int harddrive, int videocard, int soundadapter, int networkadapter, int powersupply, int floppydrive, int systemunit, int monitor, int ram1, int work) : base(cost)
{
    this.harddrive = harddrive;
    this.videocard = videocard;
    this.motherboard = motherboard;
    this.networkadapter = networkadapter;
    this.powersupply = powersupply;
    this.floppydrive = floppydrive;
    this.systemunit = systemunit;
    this.monitor = monitor;
    this.soundadapter = soundadapter;
    this.ram1 = ram1;
    this.work = work;
}

public int Harddrive { get { return harddrive; } set { this.harddrive = value; } }
public int Videocard { get { return videocard; } set { this.videocard = value; } }
public int Motherboard { get { return motherboard; } set { this.motherboard = value; } }
public int Networkadapter { get { return networkadapter; } set { this.networkadapter = value; } }
public int Powersupply { get { return powersupply; } set { this.powersupply = value; } }
public int Floppydrive { get { return floppydrive; } set { this.floppydrive = value; } }
public int Systemunit { get { return systemunit; } set { this.systemunit = value; } }
public int Monitor { get { return monitor; } set { this.monitor = value; } }
public int Soundadapter { get { return soundadapter; } set { this.soundadapter = value; } }
public int Ram1 { get { return ram1; } set { this.ram1 = value; } }
public int Work { get { return work; } set { this.work = value; } }

public int CostworkCheck()
{
    int costworkcheck;
    costworkcheck = this.Work;
    return costworkcheck;
}

public int CostComponents1(List<int> Components)
{
    Components.Add(this.Harddrive);
    Components.Add(this.Ram1);
    Components.Add(this.Videocard);
    Components.Add(this.Soundadapter);
    Components.Add(this.Networkadapter);
    Components.Add(this.Powersupply);
    Components.Add(this.Floppydrive);
    Components.Add(this.Systemunit);
    Components.Add(this.Monitor);
    Components.Add(this.Motherboard);
    Components.Add(this.Cost);
    this.Components = Components;
    return Convert.ToInt32(this.Components.Count());
}

public int CostComponents2(List<int> Costcomponents)
{
    return Convert.ToInt32(Components.Sum());
}

public int CostEverythingCheck()
{
int costeverything; 
costeverything = CostworkCheck() + CostComponents2(Components);
return costeverything;

}

}
}
