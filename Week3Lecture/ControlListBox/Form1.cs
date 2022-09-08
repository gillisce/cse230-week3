using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlListBox
{

    public partial class Form1 : Form
    {
        //Global Variables
        public bool isFirst = false;
        public bool isSecond = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //A couple things to keep in mind for the .SetItemChecked function
                //Param 1 - is the checkbox to be toggled with a 0 based starting point
                //Param 2 - is the check state
            //You could also use the function getitemChecked(0)


            if (isFirst)
            {
                clbExample.SetItemChecked(0, false);
                isFirst = false;
            }
            else
            {
                clbExample.SetItemChecked(0, true);
                isFirst = true;
            }

            //Everything above could be simplifed to
                    
                    // The line below flips the bool value and saves it back into the variable
                    //The ! is the not operator
                //isFirst = !isFirst;
                //Once we flipped the bool value we can use that to set the value of the element in the listbox
                //clbExample.SetItemChecked(0, isFirst);

        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            //Instead using the conditional logic of button 1
             //Here i am setting the isSecond bool to the current value of the checkbox
                //Will return either true or false

            isSecond = clbExample.GetItemChecked(1);

            //Now that I have the current value of the checkbox
                //I want to toggle the checkbox
                //We can do this by using the "!"
                    //Remember this is the not operator
            //So we will call the .SetItemChecked funtion and pass in
                // !isSecond - or not IsSecond
                    // Not True = false
                    // Not False = true
            clbExample.SetItemChecked(1, !isSecond);
    
        }

        private void btnIndeterminate_Click(object sender, EventArgs e)
        {
            //CheckState Inderterminate 
                //Sets the checkbox state to a grayed out (disabled) state
                
            clbExample.SetItemCheckState(1, CheckState.Indeterminate);
            //clbExample.SetItemCheckState(2, CheckState.Indeterminate);
        }

        private void btnAdd4th_Click(object sender, EventArgs e)
        {
            //A property on the checkListBox is Items
                //This a Collection of all the String values in the list
                //We can use the Contains method that will return a true or false of the exact string we pass in
                    //Then if its not there we can use the .Add() function to add it to our list
                //With the if statement we ensure we never add "Four" more than once
            if(clbExample.Items.Contains("Four") != true)
            {
                clbExample.Items.Add("Four");
            }
        }

        private void btnAddRange_Click(object sender, EventArgs e)
        {
            //Here we are using the .AddRange()
                //This takes a Parameter of a string array
            //Notice how we don't use an If to check if any of the values exist
            //What happens if you click the button more than once?
                //Is it the outcome you were expecting?
            clbExample.Items.AddRange(new string[] { "Five", "Six", "Seven" });
        }

        private void btnAdd2Half_Click(object sender, EventArgs e)
        {
            // the .Insert function takes 2 params
                //Param 1 - Index you would like to place remember this is 0 based
                //Param 2 - Value to insert
            clbExample.Items.Insert(2, "2 1/2");
        }

        private void btnRemove2Half_Click(object sender, EventArgs e)
        {
            //the .RemoveAt() takes only one param
                //Param 1 - index you want to remove it
            //What happens if you click this but you haven't added 2 1/2 to the list yet?
                //Why is that? 
                //What could you do to ensure you would accidently remove the wrong value?

            clbExample.Items.RemoveAt(2);
        }

        private void btnSubtract3_Click(object sender, EventArgs e)
        {
            // .Remove() takes parameter of the value of the item you want to remove
            //What happens if you click this and you already removed this value to the list yet?
                //Why is that? 
                //What could you do to ensure you would accidently remove the wrong value?

            clbExample.Items.Remove("Three");
        }

        private void btnGetIndex_Click(object sender, EventArgs e)
        {
            //The .indexOf takes the parameter of the value of the item in the list you want view

            int indexOfValue = clbExample.Items.IndexOf("Two");
            MessageBox.Show(indexOfValue.ToString());

            //Or be real fancy
            MessageBox.Show(clbExample.Items.IndexOf("Two").ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //.Clear will just remove all the values
            clbExample.Items.Clear();
        }
    }
}
