// קלוט 7 ציונים של תלמידים במתמטיקה 
// חשב את ההמוצע והדפס אותו 
//מצא את הציונים שמעל הממוצע והדפס 

int[] mark = new int[9];//הגדרת משתנה [] סכום כל ציון 
int sumMark = 0; // סכום כל הציונים ביחד 
for (int i = 0; i < 9; i++)
{
    Console.WriteLine("enter marks {0} : ", i + 1);// פלוס אחד כי המשתמש צריך לראות את זה מאחד ולא מאפס 
    mark[i] = int.Parse(Console.ReadLine());
    sumMark = sumMark + mark[i];

}
double avg = sumMark / 9;
Console.WriteLine("the  avg : {0}  ", avg);

for (int i = 0; i < 9; i++)
{
    if (mark[i] > avg)
    {
        Console.WriteLine("the mark high from avg : {0}   ", mark[i]);
    }
    else
    {

    }
}




//קלט -7 ציונים מטיפוס שלם  
//הממצוע והציונים שמעל הממוצע 


//הגדרת משתנים 
int[] markk= new int[7];//הגדרת מערך 
int sumMarks = 0;// the summry of mark
double avgg = 0;//ממצוע 

//תהליך הקליטה וצבירה 
for (int i = 0;i < 7; i++) {// כל עוד  קטן מ אורך המערך הלופ ימשיך I

    Console.WriteLine("please enter a mark {0}  " ,i+1 );// i will run 0-6 but its i+ 1 beoucse we want the user see mark 1 and no 0 
    markk[i] = int.Parse(Console.ReadLine());
    sumMarks = sumMarks + markk[i];//summarks here will always update from every time mark will be added so mark [i] so [i] its place of the mark 0-6 

}
avgg= (double)sumMarks/markk.Length;//double becouse summark its int so we need make it double 
Console.WriteLine("the average is : {0} ", avgg); //the avg print 
// מציאה והדפב של הציונים מעל הממוצע 
for (int i = 0;i < 7; i++)
{
    if (markk[i] > avgg)
    {
        Console.WriteLine("above avg :  {0}  ", markk[i]);
    }
}