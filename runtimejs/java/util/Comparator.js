//reference// java/lang/NullPointerException
//load// java/lang/Object
var java_util_Comparator = { 
    _superinterfaces: [], 
    _defaults: {
        reversed_0: function()
        {   return new java_util_ComparatorReversed(this);
        },
        thenComparing_1Ljava_util_Comparator$: function(other)
        {   if (other===null)
            {   throw (new java_lang_NullPointerException())._0()._e;
            }
            return new java_util_ComparatorThenComparing(this,other);
        },
    }
}; 

// -- methods:
// int compare(T o1, T o2)

var java_util_ComparatorReversed = function(a) 
  // internal use only - integrate allocator with constructor 
{   this.a = a;
};
_defclass(java_util_ComparatorReversed, java_lang_Object, [java_util_Comparator], 
{   compare_2: function(x,y) 
    {   return this.a.compare_2(y,x);
    },        
    reversed_0: function() 
    {   return this.a;
    },        
});

var java_util_ComparatorThenComparing = function(a,b)
   // internal use only - integrate allocator with constructor 
{   this.a = a;
    this.b = b;
};
_defclass(java_util_ComparatorThenComparing, java_lang_Object, [java_util_Comparator], 
{   compare_2: function(x,y) 
    {   var v = this.a.compare_2(x,y);
        if (v!==0) return v;
        return this.b.compare_2(x,y);
    },        
});
