///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all selected columns                                //
//      and convert them from snake case to title case                               //
///////////////////////////////////////////////////////////////////////////////////////


#r "System.Globalization"
 
var textInfo = new System.Globalization.CultureInfo("en-US",false).TextInfo;

foreach(var c in Selected.Columns)
{
  c.Name = textInfo.ToTitleCase( c.Name.Replace("_", " ") );   
};