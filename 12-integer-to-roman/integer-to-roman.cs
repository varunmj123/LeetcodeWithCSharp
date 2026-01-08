public class Solution {
    public string IntToRoman(int num) {
        // constraints: 1 <= num <= 3999
        string finalOutput = "";
        int initialNumber  = num;
        int numberOfDigits = 0;
        int temp = num;

        // count digits
        while(temp > 0){
            temp /= 10;
            numberOfDigits++;
        }

        while(numberOfDigits > 0){
            switch (numberOfDigits){
                case 1: 
                    finalOutput += oneDigit(initialNumber % 10);
                    numberOfDigits--;
                    break;

                case 2: 
                    finalOutput += twoDigit((initialNumber / 10) % 10);
                    numberOfDigits--;
                    break;

                case 3:
                    finalOutput += threeDigit((initialNumber / 100) % 10);
                    numberOfDigits--;
                    break;

                case 4:
                    finalOutput += fourDigit(initialNumber / 1000);
                    numberOfDigits--; 
                    break;
            }
        }
        return finalOutput;
    }

    public string oneDigit(int numberToProcess){
        string output = "";

        if(numberToProcess == 9){
            output += "IX";
            return output;
        }
        if(numberToProcess == 5){
            output += "V";
            return output;
        }
        if(numberToProcess == 4){
            output += "IV";
            return output;
        }
        if(numberToProcess < 4){
            while(numberToProcess > 0){
                output += "I";
                numberToProcess--;
            }
            return output;
        }
        if(numberToProcess > 5){
            output += "V";
            while(numberToProcess > 5){
                output += "I";
                numberToProcess--;
            }
            return output;
        }
        return output;
    }

    public string twoDigit(int numberToProcess){
        string output = "";

        if(numberToProcess == 9){
            output += "XC";
            return output;
        }
        if(numberToProcess == 5){
            output += "L";
            return output;
        }
        if(numberToProcess == 4){
            output += "XL";
            return output;
        }
        if(numberToProcess < 4){
            while(numberToProcess > 0){
                output += "X";
                numberToProcess--;
            }
            return output;
        }
        if(numberToProcess > 5){
            output += "L";
            while(numberToProcess > 5){
                output += "X";
                numberToProcess--;
            }
            return output;
        }
        return output;
    }

    public string threeDigit(int numberToProcess){
        string output = "";

        if(numberToProcess == 9){
            output += "CM";
            return output;
        }
        if(numberToProcess == 5){
            output += "D";
            return output;
        }
        if(numberToProcess == 4){
            output += "CD";
            return output;
        }
        if(numberToProcess < 4){
            while(numberToProcess > 0){
                output += "C";
                numberToProcess--;
            }
            return output;
        }
        if(numberToProcess > 5){
            output += "D";
            while(numberToProcess > 5){
                output += "C";
                numberToProcess--;
            }
            return output;
        }
        return output;
    }

    public string fourDigit(int numberToProcess){
        string output = "";
        // Wont be greater than 3
        while(numberToProcess > 0){
            output += "M";
            numberToProcess--;
        }
        return output;
    }
}
