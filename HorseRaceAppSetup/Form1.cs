using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HorseRaceAppSetup
{
    public partial class Form1 : Form
    {

        //initialization
        List<string> availableNames = new List<string>() { "Bella", "Sugar", "Alex", "Alexia", 
            "Lady", "Tucker", "Fancy", "Cash", "Dakota", "Daisy", "Spirit", "Cisco", 
            "Annie", "Buddy", "Chance", "Dallas", "Star", "Scout", "Lucky", 
            "LadyBug", "Stinky", "Cricket", "Magic", "Red", "Bruno", "Sunshine", 
            "Storm", "Rose", "Storm", "Cloud" };

        Random randInt = new Random();
        List<Horse> horses = new List<Horse>();


        //Student Point
        //<enter student id here>
        private void setHorse()
        {
            
        }
        //Given by VS. 
        public Form1()
        {
            InitializeComponent();
        }
        //This method runs when the form starts 
        private void Form1_Load(object sender, EventArgs e)
        {
            btnMax.Enabled = false;
            btnMin.Enabled = false;
            btnAddHorse.Enabled = false;

        }

        
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //SC5 and SC6
            for(int x = 0; x < 10; x++)
            {
                int nameIndex, raceIndex;
                string horseName;


                nameIndex = randInt.Next(availableNames.Count - 1);     //defines the index for the horse name
                raceIndex = randInt.Next(99);                   //defines the race number 
                horseName = availableNames[nameIndex];          //sets horse name from available names
                availableNames.RemoveAt(nameIndex);             //removes horse name from available names


                horses.Add(new Horse(horseName, raceIndex));    //create new horse
                Thread.Sleep(1);

                //MessageBox.Show($"Name: {rawString[nameIndex]} /n Number: {raceIndex}");

                listHorses1.Text += $"{horses.Last().getInfo()} \n";

                //listHorses1.Text += $"{horseName} #{raceIndex} \n";
            }

            //set UI buttons
            btnMax.Enabled = true;
            btnMin.Enabled = true;
            btnAddHorse.Enabled = true;
            btnCreate.Enabled = false;
        }
        
        //SC9 - Student Point
        private void btnMax_Click(object sender, EventArgs e)
        {
            
            Horse highestHorse = new Horse("nobody",0);

            foreach(Horse h in horses)
            {
                if(h.getNumber() >= highestHorse.getNumber())
                {
                    highestHorse = h;
                }
            }

            lblMax.Text = highestHorse.getNumber().ToString();
            
        } 

        //SC10 - Student Point
        private void btnMin_Click(object sender, EventArgs e)
        {
            Horse lowestHorse = new Horse("nobody", 999);

            foreach (Horse h in horses)
            {
                if (h.getNumber() <= lowestHorse.getNumber())
                {
                    lowestHorse = h;
                }
            }

            lblMin.Text = lowestHorse.getNumber().ToString();
        }

        //Student Point x3
        private void btnAddHorse_Click(object sender, EventArgs e)
        {

            bool isNumberValid=false, isNameValid = false;

            if(string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtNumber.Text))
            {
                MessageBox.Show("Please enter in a name and number.");
            }
            


            if(!txtName.Text.Equals("Name Entry") && !string.IsNullOrEmpty(txtName.Text))
            {
                isNameValid = true;
            }

            if (!txtNumber.Text.Equals("Number Entry") && !string.IsNullOrEmpty(txtName.Text))
            {
                isNameValid = true;
            }



            if (isNumberValid && isNameValid)
            {
                MessageBox.Show("Add Horsey....");
            }
            else
            {
                MessageBox.Show("I don't thing so buddy!!!!");
            }


        }

        private void listHorses1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
