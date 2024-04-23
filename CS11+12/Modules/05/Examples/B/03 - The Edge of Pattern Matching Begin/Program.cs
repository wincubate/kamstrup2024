using Wincubate.Module05.B;

List<object> mixOfObjects =
[
    true,
    87,
    "Hello World",
    176.0
];

foreach (object o in mixOfObjects)
{
    // Perform distinct handling depending upon the runtime type of o
    //switch (o)
    //{
    //    case bool b:
    //        ObjectHandler.Handle(b);
    //        break;
    //    case int i:
    //        ObjectHandler.Handle(i);
    //        break;
    //    case double d:
    //        ObjectHandler.Handle(d);
    //        break;
    //    case string s:
    //        ObjectHandler.Handle(s);
    //        break;
    //    //default:
    //}
}
