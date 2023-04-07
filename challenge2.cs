string text = "Meti Developer";

var a=text.Substring(text.Length - 1);//r
var b = text.Substring(1, text.Length - 2);//eti Develope
var c = text.Substring(0,1);//M
Console.WriteLine(text.Length>1?a+b+c:text);
