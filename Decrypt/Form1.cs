namespace Decrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Decryptor_Enter(object sender, EventArgs e)
        {

        }

        void EncryptText(object sender, EventArgs e)
        {

            string EncryptionText = EText.Text;
            int EncryptionTextLenght = EText.TextLength;

            decimal EncshiftXAmountDec = EShiftX.Value;
            int EnShfXAmount = Convert.ToInt32(EncshiftXAmountDec);
            decimal ErotYDec = ERotY.Value;
            int RotY = Convert.ToInt32(ErotYDec);

            char[] letters = EncryptionText.ToCharArray();
            for (int i = 0; i < EncryptionTextLenght; i++)
            {
                if(RotY == 0)
                {
                    if (EnShfXAmount == 0)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = '.';
                        }
                    }
                    else if (EnShfXAmount == 1)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'y';
                        }

                    }
                    else if (EnShfXAmount == 2)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'z';
                        }
                    }
                }
                else if(RotY == 1) {
                    if (EnShfXAmount == 0)
                    {
                        if (letters[i] == 'J')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = '.';
                        }
                    }
                    else if (EnShfXAmount == 1)
                    {
                        if (letters[i] == 'J')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'y';
                        }

                    }
                    else if (EnShfXAmount == 2)
                    {
                        if (letters[i] == 'J')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'z';
                        }
                    }

                }
                else if(RotY == 2)
                {
                    if (EnShfXAmount == 0)
                    {
                        if (letters[i] == 'S')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = '.';
                        }
                    }
                    else if (EnShfXAmount == 1)
                    {
                        if (letters[i] == 'S')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'y';
                        }

                    }
                    else if (EnShfXAmount == 2)
                    {
                        if (letters[i] == 'S')
                        {
                            letters[i] = 'C';
                        }
                       else if (letters[i] == 'T')
                        {
                            letters[i] = 'A';
                        }
                       else if (letters[i] == 'U')
                        {
                            letters[i] = 'B';
                        }
                       else if (letters[i] == 'V')
                        {
                            letters[i] = 'F';
                        }
                       else if (letters[i] == 'W')
                        {
                            letters[i] = 'D';
                        }
                       else if (letters[i] == 'X')
                        {
                            letters[i] = 'E';
                        }
                       else if (letters[i] == 'Y')
                        {
                            letters[i] = 'I';
                        }
                       else if (letters[i] == 'Z')
                        {
                            letters[i] = 'G';
                        }
                       else if (letters[i] == '&')
                        {
                            letters[i] = 'H';
                        }
                       else if (letters[i] == 'a')
                        {
                            letters[i] = 'L';
                        }
                       else if (letters[i] == 'b')
                        {
                            letters[i] = 'J';
                        }
                       else if (letters[i] == 'c')
                        {
                            letters[i] = 'K';
                        }
                       else if (letters[i] == 'd')
                        {
                            letters[i] = 'O';
                        }
                       else if (letters[i] == 'e')
                        {
                            letters[i] = 'M';
                        }
                       else if (letters[i] == 'f')
                        {
                            letters[i] = 'N';
                        }
                       else if (letters[i] == 'g')
                        {
                            letters[i] = 'R';
                        }
                       else if (letters[i] == 'h')
                        {
                            letters[i] = 'P';
                        }
                       else if (letters[i] == 'i')
                        {
                            letters[i] = 'Q';
                        }
                       else if (letters[i] == 'j')
                        {
                            letters[i] = 'U';
                        }
                       else if (letters[i] == 'k')
                        {
                            letters[i] = 'S';
                        }
                       else if (letters[i] == 'l')
                        {
                            letters[i] = 'T';
                        }
                       else if (letters[i] == 'm')
                        {
                            letters[i] = 'X';
                        }
                       else if (letters[i] == 'n')
                        {
                            letters[i] = 'W';
                        }
                       else if (letters[i] == 'o')
                        {
                            letters[i] = 'V';
                        }
                       else if (letters[i] == 'p')
                        {
                            letters[i] = '&';
                        }
                       else if (letters[i] == 'q')
                        {
                            letters[i] = 'Y';
                        }
                       else if (letters[i] == 'r')
                        {
                            letters[i] = 'Z';
                        }
                       else if (letters[i] == 's')
                        {
                            letters[i] = 'c';
                        }
                       else if (letters[i] == 't')
                        {
                            letters[i] = 'a';
                        }
                       else if (letters[i] == 'u')
                        {
                            letters[i] = 'b';
                        }
                       else if (letters[i] == 'v')
                        {
                            letters[i] = 'f';
                        }
                       else if (letters[i] == 'w')
                        {
                            letters[i] = 'd';
                        }
                       else if (letters[i] == 'x')
                        {
                            letters[i] = 'e';
                        }
                       else if (letters[i] == 'y')
                        {
                            letters[i] = 'i';
                        }
                       else if (letters[i] == 'z')
                        {
                            letters[i] = 'g';
                        }
                       else if (letters[i] == '.')
                        {
                            letters[i] = 'h';
                        }
                       else if (letters[i] == 'A')
                        {
                            letters[i] = 'l';
                        }
                       else if (letters[i] == 'B')
                        {
                            letters[i] = 'j';
                        }
                       else if (letters[i] == 'C')
                        {
                            letters[i] = 'k';
                        }
                       else if (letters[i] == 'D')
                        {
                            letters[i] = 'o';
                        }
                       else if (letters[i] == 'E')
                        {
                            letters[i] = 'm';
                        }
                       else if (letters[i] == 'F')
                        {
                            letters[i] = 'n';
                        }
                       else if (letters[i] == 'G')
                        {
                            letters[i] = 'r';
                        }
                       else if (letters[i] == 'H')
                        {
                            letters[i] = 'p';
                        }
                       else if (letters[i] == 'I')
                        {
                            letters[i] = 'q';
                        }
                       else if (letters[i] == 'J')
                        {
                            letters[i] = 'u';
                        }
                       else if (letters[i] == 'K')
                        {
                            letters[i] = 's';
                        }
                       else if (letters[i] == 'L')
                        {
                            letters[i] = 't';
                        }
                       else if (letters[i] == 'M')
                        {
                            letters[i] = 'x';
                        }
                       else if (letters[i] == 'N')
                        {
                            letters[i] = 'w';
                        }
                       else if (letters[i] == 'O')
                        {
                            letters[i] = 'v';
                        }
                       else if (letters[i] == 'P')
                        {
                            letters[i] = '.';
                        }
                       else if (letters[i] == 'Q')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'z';
                        }
                    }
                }
                
            }


            EncryptionText = new string(letters);
                EncryptionText = EncryptionText.Replace(" ", "ACT[SPACE]");
                EncryptionText = EncryptionText.Replace("!", "SYMBOL[LOUD]");
                EncryptionText = EncryptionText.Replace("@", "SYMBOL[ADRESS]");
                EncryptionText = EncryptionText.Replace("#", "SYMBOL[OCTOTHORB]");
                EncryptionText = EncryptionText.Replace("$", "SYMBOL[DOLLAR]");
                EncryptionText = EncryptionText.Replace("%", "SYMBOL[PRECENTAGE]");
                EncryptionText = EncryptionText.Replace("^", "SYMBOL[POWER]");
                EncryptionText = EncryptionText.Replace("&", "SYMBOL[AMPERSAND]");
                EncryptionText = EncryptionText.Replace("*", "SYMBOL[MULTIPLAYEDTO]");
                EncryptionText = EncryptionText.Replace("(", "SYMBOL[START]");
                EncryptionText = EncryptionText.Replace(")", "SYMBOL[END]");
                EncryptionText = EncryptionText.Replace("-", "SYMBOL[MINUS]");
                EncryptionText = EncryptionText.Replace("_", "SYMBOL[FLOOR]");
                EncryptionText = EncryptionText.Replace("=", "SYMBOL[IS]");
                EncryptionText = EncryptionText.Replace("+", "SYMBOL[PLUS]");
                EncryptionText = EncryptionText.Replace("1", "VAR DISPLAY[1]");
                EncryptionText = EncryptionText.Replace("2", "VAR DISPLAY[2]");
                EncryptionText = EncryptionText.Replace("3", "VAR DISPLAY[3]");
                EncryptionText = EncryptionText.Replace("4", "VAR DISPLAY[4]");
                EncryptionText = EncryptionText.Replace("5", "VAR DISPLAY[5]");
                EncryptionText = EncryptionText.Replace("6", "VAR DISPLAY[6]");
                EncryptionText = EncryptionText.Replace("7", "VAR DISPLAY[7]");
                EncryptionText = EncryptionText.Replace("8", "VAR DISPLAY[8]");
                EncryptionText = EncryptionText.Replace("9", "VAR DISPLAY[9]");
                EncryptionText = EncryptionText.Replace("0", "VAR DISPLAY[0]");
            Eresult.Text = EncryptionText;


        }

        void DecryptText(object sender, EventArgs e)
        {

            string DecryptionText = Dtext.Text;
            DecryptionText = DecryptionText.Replace("ACT[SPACE]", " ");
            DecryptionText = DecryptionText.Replace("SYMBOL[LOUD]", "!");
            DecryptionText = DecryptionText.Replace("SYMBOL[ADRESS]", "@");
            DecryptionText = DecryptionText.Replace("SYMBOL[OCTOTHORB]", "#");
            DecryptionText = DecryptionText.Replace("SYMBOL[DOLLAR]", "$");
            DecryptionText = DecryptionText.Replace("SYMBOL[PRECENTAGE]", "%");
            DecryptionText = DecryptionText.Replace("SYMBOL[POWER]", "^");
            DecryptionText = DecryptionText.Replace("SYMBOL[AMPERSAND]", "&");
            DecryptionText = DecryptionText.Replace("SYMBOL[MULTIPLAYEDTO]", "*");
            DecryptionText = DecryptionText.Replace("SYMBOL[START]", "(");
            DecryptionText = DecryptionText.Replace("SYMBOL[END]", ")");
            DecryptionText = DecryptionText.Replace("SYMBOL[MINUS]", "-");
            DecryptionText = DecryptionText.Replace("SYMBOL[FLOOR]", "_");
            DecryptionText = DecryptionText.Replace("SYMBOL[IS]", "=");
            DecryptionText = DecryptionText.Replace("SYMBOL[PLUS]", "+");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[1]", "1");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[2]", "2");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[3]", "3");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[4]", "4");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[5]", "5");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[6]", "6");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[7]", "7");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[8]", "8");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[9]", "9");
            DecryptionText = DecryptionText.Replace("VAR DISPLAY[0]", "0");
            int DecryptionTextLenght = DecryptionText.Length;

            decimal DecshiftXAmountDec = DShiftX.Value;
            int DcShfXAmount = Convert.ToInt32(DecshiftXAmountDec);
            decimal ErotYDec = DRotY.Value;
            int RotY = Convert.ToInt32(ErotYDec);

            char[] letters = DecryptionText.ToCharArray();
            for (int i = 0; i < DecryptionTextLenght; i++) 
            {

                if(RotY == 0)
                {
                    if (DcShfXAmount == 0)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = '.';
                        }
                    }
                    else if (DcShfXAmount == 1)
                    {
                        if (letters[i] == 'B')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = '.';
                        }

                    }
                    else if (DcShfXAmount == 2)
                    {

                        if (letters[i] == 'C')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = '.';
                        }

                    }
                }
                if(RotY == 1)
                {
                    if (DcShfXAmount == 0)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'I';
                        }
                    }
                    else if (DcShfXAmount == 1)
                    {
                        if (letters[i] == 'B')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'I';
                        }

                    }
                    else if (DcShfXAmount == 2)
                    {

                        if (letters[i] == 'C')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'R';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'I';
                        }

                    }
                }
                if(RotY == 2)
                {
                    if (DcShfXAmount == 0)
                    {
                        if (letters[i] == 'A')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'R';
                        }
                    }
                    else if (DcShfXAmount == 1)
                    {
                        if (letters[i] == 'B')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'C')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'R';
                        }

                    }
                    else if (DcShfXAmount == 2)
                    {

                        if (letters[i] == 'C')
                        {
                            letters[i] = 'S';
                        }
                        else if (letters[i] == 'A')
                        {
                            letters[i] = 'T';
                        }
                        else if (letters[i] == 'B')
                        {
                            letters[i] = 'U';
                        }
                        else if (letters[i] == 'F')
                        {
                            letters[i] = 'V';
                        }
                        else if (letters[i] == 'D')
                        {
                            letters[i] = 'W';
                        }
                        else if (letters[i] == 'E')
                        {
                            letters[i] = 'X';
                        }
                        else if (letters[i] == 'I')
                        {
                            letters[i] = 'Y';
                        }
                        else if (letters[i] == 'G')
                        {
                            letters[i] = 'Z';
                        }
                        else if (letters[i] == 'H')
                        {
                            letters[i] = '&';
                        }
                        else if (letters[i] == 'L')
                        {
                            letters[i] = 'a';
                        }
                        else if (letters[i] == 'J')
                        {
                            letters[i] = 'b';
                        }
                        else if (letters[i] == 'K')
                        {
                            letters[i] = 'c';
                        }
                        else if (letters[i] == 'O')
                        {
                            letters[i] = 'd';
                        }
                        else if (letters[i] == 'M')
                        {
                            letters[i] = 'e';
                        }
                        else if (letters[i] == 'N')
                        {
                            letters[i] = 'f';
                        }
                        else if (letters[i] == 'R')
                        {
                            letters[i] = 'g';
                        }
                        else if (letters[i] == 'P')
                        {
                            letters[i] = 'h';
                        }
                        else if (letters[i] == 'Q')
                        {
                            letters[i] = 'i';
                        }
                        else if (letters[i] == 'U')
                        {
                            letters[i] = 'j';
                        }
                        else if (letters[i] == 'S')
                        {
                            letters[i] = 'k';
                        }
                        else if (letters[i] == 'T')
                        {
                            letters[i] = 'l';
                        }
                        else if (letters[i] == 'X')
                        {
                            letters[i] = 'm';
                        }
                        else if (letters[i] == 'W')
                        {
                            letters[i] = 'n';
                        }
                        else if (letters[i] == 'V')
                        {
                            letters[i] = 'o';
                        }
                        else if (letters[i] == '&')
                        {
                            letters[i] = 'p';
                        }
                        else if (letters[i] == 'Y')
                        {
                            letters[i] = 'q';
                        }
                        else if (letters[i] == 'Z')
                        {
                            letters[i] = 'r';
                        }
                        else if (letters[i] == 'c')
                        {
                            letters[i] = 's';
                        }
                        else if (letters[i] == 'a')
                        {
                            letters[i] = 't';
                        }
                        else if (letters[i] == 'b')
                        {
                            letters[i] = 'u';
                        }
                        else if (letters[i] == 'f')
                        {
                            letters[i] = 'v';
                        }
                        else if (letters[i] == 'd')
                        {
                            letters[i] = 'w';
                        }
                        else if (letters[i] == 'e')
                        {
                            letters[i] = 'x';
                        }
                        else if (letters[i] == 'i')
                        {
                            letters[i] = 'y';
                        }
                        else if (letters[i] == 'g')
                        {
                            letters[i] = 'z';
                        }
                        else if (letters[i] == 'h')
                        {
                            letters[i] = '.';
                        }
                        else if (letters[i] == 'l')
                        {
                            letters[i] = 'A';
                        }
                        else if (letters[i] == 'j')
                        {
                            letters[i] = 'B';
                        }
                        else if (letters[i] == 'k')
                        {
                            letters[i] = 'C';
                        }
                        else if (letters[i] == 'o')
                        {
                            letters[i] = 'D';
                        }
                        else if (letters[i] == 'm')
                        {
                            letters[i] = 'E';
                        }
                        else if (letters[i] == 'n')
                        {
                            letters[i] = 'F';
                        }
                        else if (letters[i] == 'r')
                        {
                            letters[i] = 'G';
                        }
                        else if (letters[i] == 'p')
                        {
                            letters[i] = 'H';
                        }
                        else if (letters[i] == 'q')
                        {
                            letters[i] = 'I';
                        }
                        else if (letters[i] == 'u')
                        {
                            letters[i] = 'J';
                        }
                        else if (letters[i] == 's')
                        {
                            letters[i] = 'K';
                        }
                        else if (letters[i] == 't')
                        {
                            letters[i] = 'L';
                        }
                        else if (letters[i] == 'x')
                        {
                            letters[i] = 'M';
                        }
                        else if (letters[i] == 'w')
                        {
                            letters[i] = 'N';
                        }
                        else if (letters[i] == 'v')
                        {
                            letters[i] = 'O';
                        }
                        else if (letters[i] == '.')
                        {
                            letters[i] = 'P';
                        }
                        else if (letters[i] == 'y')
                        {
                            letters[i] = 'Q';
                        }
                        else if (letters[i] == 'z')
                        {
                            letters[i] = 'R';
                        }

                    }
                }
            }

            DecryptionText = new string(letters);
            Dresult.Text = DecryptionText;

        }

        void CopyEncrypted(object sender, EventArgs e)
        {
            Clipboard.SetText(Eresult.Text);
            MessageBox.Show("Tekst zosta³ skopiowany do schowka");
        }

        void CopyDecrypted(object sender, EventArgs e)
        {
            Clipboard.SetText(Dresult.Text);
            MessageBox.Show("Tekst zosta³ skopiowany do schowka");
        }
    }
    



}
