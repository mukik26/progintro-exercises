// declare variables
int[] grades = [4, 7, 02, 00, 10, 4, 12];
float count = 0f;
int sum = 0;

// if the grade is lower than 2 an exception is trown.
int GetGrade (int courseid){
    int grade = grades[courseid];
        if (grade < 2) {
            throw new Exception("You Failed");
        }
        return grade;
}

for (int courseid = 0; courseid < grades.Length; courseid++){
    try {
     sum += GetGrade(courseid);
     count++;   
    } catch (Exception){
        Console.WriteLine("Caught an Expection!");
    }
}

Console.WriteLine("The average is "+(sum/count));