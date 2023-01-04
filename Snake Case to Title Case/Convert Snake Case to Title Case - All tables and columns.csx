///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all the tables in the model                         //
//      and convert snake case all the table/columns names to title case             //
///////////////////////////////////////////////////////////////////////////////////////


#r "System.Globalization"

var textInfo = new System.Globalization.CultureInfo("en-US",false).TextInfo;


// Looping through all tables in the model
foreach(var t in Model.Tables) 
{
    t.Name = textInfo.ToTitleCase( t.Name.Replace("_", " ") );

    // Looping through columns in the table
    foreach(var c in t.Columns)
    {
      c.Name = textInfo.ToTitleCase( c.Name.Replace("_", " ") );   
    };
    
};



