namespace IntToRomanNumerals
{
    public class ConvertFromIntToNumeral
    {
        public int UserInput;

        public readonly Dictionary<int, char> Numerals = new()
    {
        {1000, 'M'},
        {500,'D'},
        {100,'C'},
        {50, 'L'},
        {10,'X'},
        {5,'V'},
        {1,'I'}
    };
        public string ConvertIntToNumeral(int userInput)
        {
            var result = string.Empty;
            this.UserInput = userInput;

            try {
                var convertedInput = Convert.ToString(UserInput);


                foreach (char num in convertedInput)

                    foreach (int key in Numerals.Keys)
                    {
                        while (UserInput / key >= key)
                        {
                            result += Numerals[key].ToString();
                            UserInput -= key;
                        }
                    }
            }
            catch (Exception ex) 
            {
                throw new ArgumentException(ex.Message);
            }
            return result;


        }

    }
}