# YERP 

YARP (Yet Another Reverse Proxy) is a high-performance reverse proxy library developed by Microsoft for ASP.NET Core. It enables API Gateway scenarios such as load balancing, request routing, authentication, rate limiting, health checks, and service discovery while remaining fully customizable through .NET code.

## Load Balancing Policies

### Round Robin

Requests are distributed sequentially across all available instances. This approach provides an even load distribution and is simple to understand and implement.

### Random

Each incoming request is routed to a randomly selected backend instance. While simple, the distribution may become uneven over short periods of time.

### Power Of Two Choices

Two backend instances are selected at random, and the request is routed to the one with fewer active requests. This strategy typically achieves better load distribution and lower latency than pure Round Robin or Random balancing.

### How to test

Run all 3 services and then open https://localhost:7181/api

<img width="407" height="157" alt="image" src="https://github.com/user-attachments/assets/366ed5d9-ba06-4e88-9d8f-ed591bcbebbc" />


## FastApi

## RateLimiting

