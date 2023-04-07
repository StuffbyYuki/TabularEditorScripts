///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script adds a new line at the beginning of your all DAX measures        //
///////////////////////////////////////////////////////////////////////////////////////

foreach (var m in Model.AllMeasures) 
{
    m.Expression = "\n" + m.Expression;   
}
