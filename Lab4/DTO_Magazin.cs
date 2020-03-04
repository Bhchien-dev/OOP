using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_lab4OOP
{
    public class DTO_Magazin
    {
        private string _MAGAZIN_ID;
        private string _MAGAZIN_NAME;
        private string _MAGAZIN_ADRESS;
        private string _ITEM_ID;
        private string _ITEM_NAME;
        private string _ITEM_COST;
        private int _ITEM_STOCK;

        public string MAGAZIN_ID
        {
            get { return _MAGAZIN_ID; }
            set { _MAGAZIN_ID = value; }
        }
        public string MAGAZIN_NAME
        {
            get { return _MAGAZIN_NAME; }
            set { _MAGAZIN_NAME = value; }
        }
        public string MAGAZIN_ADRESS
        {
            get { return _MAGAZIN_ADRESS; }
            set { _MAGAZIN_ADRESS = value; }
        }
        public string ITEM_ID
        {
            get { return _ITEM_ID; }
            set { _ITEM_ID = value; }
        }
        public string ITEM_NAME
        {
            get { return _ITEM_NAME; }
            set { _ITEM_NAME = value; }
        }
        public string ITEM_COST
        {
            get { return _ITEM_COST; }
            set { _ITEM_COST = value; }
        }
        public int ITEM_STOCK
        {
            get { return _ITEM_STOCK; }
            set { _ITEM_STOCK = value; }
        }
        public DTO_Magazin(string ID, string NAME, string ADRESS)
        {
            this.MAGAZIN_ID = ID;
            this.MAGAZIN_NAME = NAME;
            this.MAGAZIN_ADRESS = ADRESS;
        }
        public DTO_Magazin(string ID, string NAME, string COST, int STOCK)
        {
            this.ITEM_ID = ID;
            this.ITEM_NAME = NAME;
            this.ITEM_COST = COST;
            this.ITEM_STOCK = STOCK;
        }
    }
}
