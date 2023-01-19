internal class Horse
{

    private string Name { get; set; }
    private int RaceNumber { get; set; }




    public Horse(string _Name, int _RaceNumber)
    {
        this.setName(_Name);
        this.setNumber(_RaceNumber);
    }

    //SC2
    public string getName()
    {
        return Name;
    }

    public int getNumber()
    {
        return RaceNumber;
    }

    //SC3
    public void setName(string _Name)
    {
        Name = _Name;
    }

    public void setNumber(int _RaceNumber)
    {
        RaceNumber = _RaceNumber;
    }

    //SC4
    public string getInfo()
    {
        return ($"{this.getName()} #{this.getNumber()}");  //using string interpolation

    }
}