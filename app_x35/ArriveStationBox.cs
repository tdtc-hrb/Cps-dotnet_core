using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cps_x35.Models;

namespace Cps_x35
{
    partial class ArriveStationBox : Form
    {
        public int m_nLotnum = 0;

        public ArriveStationBox()
        {
            InitializeComponent();
        }

        private List<String> GetArriveStationNames()
        {
            var result = new List<String>();

            using (var context = new PubsDbContext())
            {
                var arriveStations = context.ArriveStations.OrderBy(w => w.Id).ToList();

                foreach (var arriveStation in arriveStations)
                {
                    result.Add(arriveStation.Description);
                }
            }

            return result;
        }

        private int SetArriveId(int lotnum, int nId)
        {
            int result = 0;

            using (var context = new PubsDbContext())
            {
                var dispatchs = context.DispatchStores
                    .Where(d => d.LotNumberId == lotnum);

                foreach (var dispatch in dispatchs)
                {
                    dispatch.ArriveStationId= nId;
                }

                result = context.SaveChanges();
            }

            return result;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int iArriveId = comboBox1.SelectedIndex + 1000;

            if (SetArriveId(m_nLotnum, iArriveId) != 0)
                this.Close();
        }

        private void ArriveStationBox_Shown(object sender, EventArgs e)
        {
            //
            comboBox1.Items.Clear();
            foreach (var item in GetArriveStationNames())
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}
