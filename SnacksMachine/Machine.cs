namespace SnacksMachine {
    internal class Machine {
        //properties
        private bool doorOpened;
        private int insertedMoney;

        public bool DoorOpened {
            get { return this.doorOpened; }
            set { this.doorOpened = value; }
        }

        public int InsertedMoney {
            get { return insertedMoney; }
            set { insertedMoney = value; }
        }


        //constructor
        public Machine() {
            this.DoorOpened = false;
        }
    }
}