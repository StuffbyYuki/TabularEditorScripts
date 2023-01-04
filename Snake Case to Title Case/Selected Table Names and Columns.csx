///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all selected tables                                 //
//      and convert snake case table/columns names to title case                     //
///////////////////////////////////////////////////////////////////////////////////////


#r "System.Globalization"

var textInfo = new System.Globalization.CultureInfo("en-US",false).TextInfo;


// Looping through selected tables
foreach(var t in Selected.Tables) 
{
    t.Name = textInfo.ToTitleCase( t.Name.Replace("_", " ") );

    // Looping through columns
    foreach(var c in t.Columns)
    {
      c.Name = textInfo.ToTitleCase( c.Name.Replace("_", " ") );   
    };
    
};



