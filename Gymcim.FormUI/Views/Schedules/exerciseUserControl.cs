using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gymcim.Entities.Concrete;

namespace Gymcim.FormUI.Views.Schedules
{
    public partial class exerciseUserControl : UserControl
    {
        Color[] colors = { 
            Color.FromArgb(0, 230, 118),
            Color.FromArgb(41, 121, 255),
            Color.FromArgb (255, 23, 68),
            Color.FromArgb (213, 0, 249),
            Color.FromArgb (29, 233, 182),
            Color.FromArgb (101, 31, 255),
        };

        private List<Exercise> exercises;
        public exerciseUserControl(List<Exercise> exercises)
        {
            InitializeComponent();
            this.exercises = exercises;
        }

        private void exerciseUserControl_Load(object sender, EventArgs e)
        {
            setUI();
        }

        private void setUI()
        {
            panelHeader.BackColor = colors[new Random().Next(0, colors.Length - 1)];
            lblDay.Text = exercises[0].ExerciseDay.ToString() + ".GÜN";

            exercises.ForEach(e => AddItem(e));
        }
        private void AddItem(Exercise exercise)
        {
 
            RowStyle temp = tblExercises.RowStyles[tblExercises.RowCount - 1];
            
            tblExercises.RowCount++;

            tblExercises.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));

            tblExercises.Controls.Add(new Label() { Text = exercise.ExerciseName }, 0, tblExercises.RowCount - 1);
            tblExercises.Controls.Add(new Label() { Text = exercise.ExerciseSet.ToString() + " x " + exercise.ExerciseRep.ToString() }, 1, tblExercises.RowCount - 1);
            tblExercises.Controls.Add(new Label() { Text = exercise.Part.PartName }, 2, tblExercises.RowCount - 1);
            tblExercises.Controls.Add(new Label() { Text = exercise.ExerciseDesc }, 2, tblExercises.RowCount - 1);
        }
    }
}
