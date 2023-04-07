///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script adds a new line at the beginning of your selected DAX measures   //
///////////////////////////////////////////////////////////////////////////////////////

foreach (var m in Selected.Measures) 
{
    m.Expression = "\n" + m.Expression;   
}

