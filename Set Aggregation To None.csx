///////////////////////////////////////////////////////////////////////////////////////
// Author: Yuki Kakegawa, linkedin.com/in/yukikakegawa, twitter.com/yukithejapanese  //
// Description:                                                                      //
//      This script goes through all selected columns and set aggregation to None    //
///////////////////////////////////////////////////////////////////////////////////////


foreach(var c in Selected.Columns)
{
    c.SummarizeBy = AggregateFunction.None; // set to None
};
