﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MyException : Exception {
    public new string Message ="0で割るエラーです";

    public override string ToString()
    {
        return "0で割ってはいけません";
    }
}
