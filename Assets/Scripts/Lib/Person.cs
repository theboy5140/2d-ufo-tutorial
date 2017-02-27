using UnityEngine;

namespace Extra{

    namespace Tess{

        class Person{

            private int age;

            public Person(int age){
                this.age = age;
            }

            public void say(){

                Debug.Log (" i am " + this.age + " years old");
            }
        }
    }
}