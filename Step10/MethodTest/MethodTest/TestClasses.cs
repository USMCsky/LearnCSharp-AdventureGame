using System;

namespace MethodTest {
    class A {
        public string Method1() {
            return "class A: Method1\r\n";
        }

        public virtual string Method2() { // class A
            return "class A: (virtual) Method2\r\n";
        }

        public string Method3() {
            return "class A: Method3\r\n";
        }
    }

    // class A is the ancestor of class B  
    class B : A {
        // note 'new' keyword 
        public new string Method1() {
            return "class B: (new) Method1\r\n";
        }

        public override string Method2() {
            return "class B: (override) Method2\r\n";
        }

        public string Method3() {
            return "class B: Method3\r\n";
        }
    }

}
