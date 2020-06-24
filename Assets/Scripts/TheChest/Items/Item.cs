﻿using System;
using UnityEngine;

namespace TheChest.Items
{
    [Serializable]
    public class Item
    {
        //Maybe just keep properties 
        [Header("Basic item data")]

        [SerializeField]
        protected readonly string id;

        [SerializeField]
        protected string name;

        [SerializeField]
        protected string description;

        [SerializeField]
        protected Sprite image;

        [SerializeField]
        [Range(0,100)]
        protected int maxStack;

        public string ID => id;
        public string Name => name;

        public string Description => description;

        public Sprite Image => image;

        public int MaxStack => maxStack;

        public Item()
        {
            id = null;
            name = null;
            description = null;
            image = null;
            maxStack = 1;
        }

        public Item(string id, string name, string description, Sprite image, int maxStack)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.image = image;
            this.maxStack = maxStack;
        }
    }
}