package com.greentube.convertertest;


// A test class to test the conversion of various features from java to other languages

public class TestObject extends TestParentIntermediate {
    
    // instance attributes
    String somestring;                  // instance attribute default initializer
    int    somenumber;                  // instance attribute default initializer

    TestObject   moreobject;
    DummyClass dummyobject;

    // constructors
    public TestObject() {                  // construct without parameters
        super();                     // constructor calling superconstructor
        somenumber = 4711;
        somestring = "defaulttext";
    }

    public TestObject(String str) {        // constructor with 1 parametere
        this(str,4711);              // calling second constructor of 'this'
    }    
                                    // constructor with 2 parameters
    public TestObject(String somestring, int somenumber) { 
        super (4);                      // constructor calling superconstructor
        this.somestring = somestring;   // local variables shadowing attributes
        this.somenumber = somenumber;
    }
    public TestObject(int a, int b, int c)  { 
                                        // call default constructor of superclass     
    }
      
    public int shadowAttributeSum()
    {
    	int somenumber = 123;
    	return shadowAttribute() + somenumber + staticmethod();
    }
    public int shadowAttribute()
    {
    	return somenumber;
    }
    
    public int accessParentStatic() {
    	return staticparentattribute;
    }
    
    // should not be confused with the shadowAttribute method
    public static int shadowAttribute(int someparameter)
    {
    	return someparameter;
    }
    
}

