using System;

public class Events : Program
{
	public Events()
	{
	}
    public static void OnlyNumber(object sender, KeyPressEventArgs e)
    {
        char sym = e.KeyChar;
        if (!Char.IsDigit(sym) && sym != 8 || sym == 127)
        {
            e.Handled = true;
        }
    }

    public static void KeyPressFalse(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }
}
