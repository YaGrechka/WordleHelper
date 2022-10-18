namespace WordleHelper
{
    class Word
    {
        string char1;
        int propChar1;

        string char2;
        int propChar2;

        string char3;
        int propChar3;

        string char4;
        int propChar4;

        string char5;
        int propChar5;

        public void SetChar(int numberChar,string value, int propChar)
        {
            switch (numberChar)
            {
                case 1:
                    char1 = value;
                    propChar1 = propChar;
                    break;
                case 2:
                    char2 = value;
                    propChar2 = propChar;
                    break;
                case 3:
                    char3 = value;
                    propChar3 = propChar;
                    break;
                case 4:
                    char4 = value;
                    propChar4 = propChar;
                    break;
                case 5:
                    char5 = value;
                    propChar5 = propChar;
                    break;
            }
        }

        public string FullWord()
        {
            return char1 + char2 + char3 + char4 + char5;
        }
    }
}
