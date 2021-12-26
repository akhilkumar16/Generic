namespace JsonDataManagemnet
{
    internal class Item
    {
        internal string weight;
        internal string item;

        public Item()
        {
        }

        public string product { get; set; }
        public string Weight { get; set; }
        public string Costperkg { get; set; }
        public int PriceID { get; internal set; }
    }
}