# 🔐 JWT Authentication API – ASP.NET Core

## 📌 Project Overview
This is a simple ASP.NET Core Web API project implementing JWT (JSON Web Token) Authentication.

The project demonstrates:
- User Login
- JWT Token Generation
- Protected API Endpoints
- Reading Username from Token
- Swagger Authorization

---

## 🛠 Technologies Used
- ASP.NET Core Web API
- C#
- JWT Bearer Authentication
- Swagger (OpenAPI)
- .NET 6/7/8

---

## 🔑 How JWT Works in This Project

1. User sends username & password to Login API.
2. Server validates credentials.
3. If valid, server generates JWT token.
4. Client sends token in Authorization header:
   Authorization: Bearer {token}
5. Protected APIs validate token before returning data.

---

## 🚀 API Endpoints

### 🔓 Login API

POST /api/Auth/login

Request Body:
```json
{
  "username": "admin",
  "password": "123"
}
