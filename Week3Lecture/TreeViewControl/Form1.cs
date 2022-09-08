using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //The TreeNodeControl is a way to view things in a hierarchical manner
        //We built a simple form with 3 buttons and a text box
            //BtnAdd - uses the .Add() funtion to add a new TreeNode object to the list
            //BtnAddChild - Takes whatever node the user has selected and if its not null
                //Adds a new Child to the list
            //BtnRemove will remove whatever selected Node, either Child or Parent from the control
        //Test it out and attempt to modify the code and see what else you can discover




        private void btnAdd_Click(object sender, EventArgs e)
        {
            TreeNode node = new TreeNode(textBox1.Text);
            treeView1.Nodes.Add(node);
        }

        private void btnAddChild_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //THe Numeric value up down control gives you a simple way to allow a user to count up and donw
            // You can change the Min and Max values as well as the increment it will count via the properties
                //For this example we are just going to output the value to label
                //Think about other ways you could leverage this control 

            //IN Addition there is a Domain Up/Down Control
                //Try adding one to our form and figure out how to cycle values in this control and output them to a label

            lblNumericValue.Text = numericUpDown1.Value.ToString();
        }
    }
}
