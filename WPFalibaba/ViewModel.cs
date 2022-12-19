﻿using System.Collections.Generic;

public class ViewModel
{
    public List<Person> Data { get; set; }

    public ViewModel()
    {
        Data = new List<Person>()
            {
                new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
            };
    }
}