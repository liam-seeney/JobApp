﻿namespace JobAppUI.Models
{
    public class ResponseAPI<T>
    {
        public T? Data { get; set; }
        public string? Message { get; set; }
        public bool Success { get; set; } = true;
    }
}
