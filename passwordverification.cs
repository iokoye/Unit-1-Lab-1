using System;

class Program {
    static void Main(string[] args) {
        //Prompt user for message
        Console.Write("User, enter a valid password: ");
       
        //Console input for user.
        string userPassword = Console.ReadLine();
       
        //Instantiate object.
        Program programObjects = new Program();
       
        //Return output based on validity.
        if(programObjects.passwordValidation(userPassword)==true){
            Console.WriteLine("Password valid and accepted");
        }else{
            Console.WriteLine("Error");
        }
    }
   
    // Checks all conditions and if all are met return true otherwise return false.
    public bool passwordValidation(string userPassword){
        // I have 3 conditions all three need to be met to be valid. starts at zero and increases as each contidtion is met for a maximum count value of 3.
        int count =0;
        Program programObjects = new Program();
        if(programObjects.lengthCheck(userPassword)==true){
            count ++;
        }
        if(programObjects.checkExclamation(userPassword)==true){
            count++;
        }
        if(programObjects.caseSensitivity(userPassword)==true){
            count++;
        }
        if(count==3){
            return true;
        }
        return false;
    }
   
    // Length check minimum of 7 and a maximum of 12
    public bool lengthCheck(string userPassword){
        bool validLength = false;
        if((userPassword.Length>=7) &(userPassword.Length<=12)){
            validLength = true;
        }
        return validLength;
    }
   
    // Check for a ! mark in the string.
    //i++
    public bool checkExclamation (string userPassword){
        bool exclamation = false;
        for(int i=0; i<=userPassword.Length -1;i++){
            if(userPassword[i].Equals('!')){
                exclamation = true;
            }
        }
        return exclamation;
    }
   
    public bool caseSensitivity(string userPassword){
        bool hasLowerAndUpperCase = false;
        int countCapital = 0;
        int countLowerCase = 0;
        for(int i=0; i<=userPassword.Length-1; i++){
          if(char.IsLower(userPassword[i])==true){
              countLowerCase++;
          }if(char.IsUpper(userPassword[i])==true){
              countCapital++;
          }
        }
       
        if((countCapital>0) & (countLowerCase>0)){
            hasLowerAndUpperCase = true;
        }
       
        return hasLowerAndUpperCase;
    }
}
