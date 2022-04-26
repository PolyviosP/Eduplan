using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Eduplan
{
    class Functions
    {
        public static int TestResults(List<CheckedListBox> Box, List<string> L)
        {
            try
            {
                int Test1vathmos = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (Box[i].SelectedItem == L[i]) Test1vathmos += 2;
                }
                if (Test1vathmos == 10)
                {
                    MessageBox.Show("Συγχαρητήρια πέρασες το διαγώνισμα χωρίς κανένα λάθος με βαθμό 10/10", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Test1vathmos >= 5)
                {
                    MessageBox.Show("Συγχαρητήρια πέρασες το διαγώνισμα με βαθμό " + Test1vathmos + "/10. \n\n Μπράβο, τα πήγες περίφημα!", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Test1vathmos < 5)
                {
                    MessageBox.Show("Δυστυχώς δεν πέρασες ξαναδιάβασε την θεωρία.", "Python+", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int items = 0; items < Box[i].Items.Count; items++)
                    {
                        Box[i].SetItemChecked(items, false);
                        Box[i].ClearSelected();
                    }
                }
                return Test1vathmos;
            }
            catch { return 0; }
        }
        public static void ItemCheck(CheckedListBox Box, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < Box.Items.Count; ++ix)
                if (ix != e.Index)
                    Box.SetItemChecked(ix, false);
        }
        public static void CloseProgram(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Environment.Exit(0);
            }
        }
    }
}
