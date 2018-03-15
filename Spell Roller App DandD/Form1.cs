using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spell_Roller_App_DandD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             InitializeComponent();
        }
        string[] i = null;
       

        
        
        private void btn_Roll_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
           
            int Choice1 = rnd.Next(i.Length);
            int Choice2 = rnd.Next(i.Length);

            txt_Choice1.Text = i[Choice1];
            txt_Choice2.Text = i[Choice2];
        }

        private void rdb_Cantrips_CheckedChanged(object sender, EventArgs e)
        {
            string[] Cantrips = { "1 Acid Splash", "2 Chill Touch", "3 Fire Bolt", "4 Light", "5 Poison Spray", "6 Ray of Frost",
                              " 7 Shocking Grasp", "8 Sacred Flame", "9 Thorn Whip", "10 Re-Roll" };
            i = Cantrips;
        }

        private void rdb_One_CheckedChanged(object sender, EventArgs e)
        {
            string[] First = {"1 Burning Hands" , "2 Chromatic Orb" , "3 Color Spray" , "4 Faerie Fire" , "5 False Life" ,
                              "6 Fog Cloud" , "7 Jump" , "8 Magic Missile" , "9 Thunderwave" , "10 Re-Roll"  };
            i = First;
        }

        private void rdb_Two_CheckedChanged(object sender, EventArgs e)
        {
            string[] Second = {"1 Blur" , "2 Darkness" , "3 Enlarge/Reduce" , "4 Gust of Wind" , "5 Invisibility" ,
                               "6 Levitate" , "7 Melf’s Acid Arrow" , "8 Scorching Ray" , "9 Shatter" , "10 Re-Roll"};
            i = Second;
        }

        private void rdb_Three_CheckedChanged(object sender, EventArgs e)
        {
            string[] Third = {"1 Blink" , "2 Fear" , "3 Feign Death" , "4 Fireball" , "5 Fly" ,   
                               "6 Gaseous Form" , "7 Lightning Bolt" , "8 Sleet Storm" , "9 Stinking Cloud" , "10 Re-Roll"};
            i = Third;
        }

        private void rdb_Four_CheckedChanged(object sender, EventArgs e)
        {
            string[] Fourth = {"1 Blight" , "2 Confusion" , "3 Evard’s Black Tentacles" , "4 Fire Shield" , "5 Greater Invisibility" ,
                               "6 Ice Storm" , "7 Phantasmal Killer" , "8 Stoneskin" , "9 Wall of Fire" , "10 Re-Roll" };
            i = Fourth;
        }

        private void rdb_Five_CheckedChanged(object sender, EventArgs e)
        {
            string[] Fifth = {"1 Cloudkill" , "2 Cone of Cold" , "3 Destructive Wave" , "4 Flame Strike" , "5 Hold Monster" ,
                              "6 Insect Plague" , "7 Mass Cure Wounds" , "8 Wall of Force" , "9 Wall of Stone" , "10 Re-Roll" };
            i = Fifth;
        }

        private void rdb_Six_CheckedChanged(object sender, EventArgs e)
        {
            string[] Sixth = {"1 Cloudkill" , "2 Cone of Cold" , "3 Destructive Wave" , "4 Flame Strike" , "5 Hold Monster" ,
                              "6 Insect Plague" , "7 Mass Cure Wounds" , "8 Wall of Force" , "9 Wall of Stone" , "10 Re-Roll" };
            i = Sixth;
        }

        private void rdb_Seven_CheckedChanged(object sender, EventArgs e)
        {
            string[] Seventh = {"1 Cloudkill" , "2 Cone of Cold" , "3 Destructive Wave" , "4 Flame Strike" , "5 Hold Monster" ,
                              "6 Insect Plague" , "7 Mass Cure Wounds" , "8 Wall of Force" , "9 Wall of Stone" , "10 Re-Roll" };
            i = Seventh;
        }

        private void rdb_Eight_CheckedChanged(object sender, EventArgs e)
        {
            string[] Eighth = {"1 Cloudkill" , "2 Cone of Cold" , "3 Destructive Wave" , "4 Flame Strike" , "5 Hold Monster" ,
                              "6 Insect Plague" , "7 Mass Cure Wounds" , "8 Wall of Force" , "9 Wall of Stone" , "10 Re-Roll" };
            i = Eighth;
        }

        private void rdb_Nine_CheckedChanged(object sender, EventArgs e)
        {
            string[] Ninth = {"1 Cloudkill" , "2 Cone of Cold" , "3 Destructive Wave" , "4 Flame Strike" , "5 Hold Monster" ,
                              "6 Insect Plague" , "7 Mass Cure Wounds" , "8 Wall of Force" , "9 Wall of Stone" , "10 Re-Roll" };
            i = Ninth;
        }
    }
}
