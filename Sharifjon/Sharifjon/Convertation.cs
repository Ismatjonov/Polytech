class Convertation
    {
        // Поля (fields)
        private string number;
        private int fromBase;
        private int toBase;

        // Хосиятҳо (properties)
        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public int FromBase
        {
            get { return fromBase; }
            set { fromBase = value; }
        }

        public int ToBase
        {
            get { return toBase; }
            set { toBase = value; }
        }

        // Конструктор
        public Convertation(string num, int from, int to)
        {
            number = num;
            fromBase = from;
            toBase = to;
        }

        // Метод
        public string ConvertNumber()
        {
            try
            {
                int decimalValue = Convert.ToInt32(number, fromBase);
                string result = Convert.ToString(decimalValue, toBase);
                return result.ToUpper();
            }
            catch
            {
                return "Хато дар воридкунӣ!";
            }
        }
    }