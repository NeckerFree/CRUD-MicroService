﻿namespace Inventory.ProductManagement
{

    public class AttributeValue
    {
        public int AttributeValueId { get; set; }
        public int ProductId { get; set; }
        public int ProductAttributeId { get; set; }
        public required string Value { get; set; }
    }

}
