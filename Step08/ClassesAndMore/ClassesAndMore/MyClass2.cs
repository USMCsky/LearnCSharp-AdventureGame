namespace ClassesAndMore {
    partial class MyClass {

        public static string Capitalize(string aString) {
            string s;
            char firstchar;
            s = ToLowCase(aString.Substring(1, aString.Length - 1));
            firstchar = char.ToUpper(aString[0]);
            return firstchar + s;
        }

    }

}
