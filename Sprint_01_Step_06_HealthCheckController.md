# Sprint 01 - Step 06 - Health Check API

## Objective

Create the first API endpoint to verify that the application is running successfully.

---

## Why Health Check API?

A Health Check endpoint allows:

* Developers to verify application availability.
* DevOps teams to monitor deployments.
* Load balancers to determine service health.
* Azure App Services and IIS monitoring tools to validate application status.

---

## API Details

Endpoint:

GET /api/health

Response:

{
"status": "Healthy",
"application": "Employee Management System",
"timestamp": "UTC Date Time"
}

---

## Controller Location

EMS.API

Controllers

HealthController.cs

---

## Purpose

This endpoint acts as a lightweight verification endpoint.

It does not access:

* Database
* Authentication
* External Services

It simply confirms that the API is operational.

---

## Real World Usage

During deployments:

DEV Environment

↓

QA Environment

↓

UAT Environment

↓

PROD Environment

DevOps teams validate deployments using Health endpoints before releasing traffic to users.

---

## Learning Outcomes

* Controller Creation
* API Routing
* IActionResult Usage
* JSON Responses
* Swagger Testing

---

## Benefits

* Quick Verification
* Monitoring Support
* Deployment Validation
* Troubleshooting

---

## Status

Completed Successfully

---

## Lessons Learned

A Health Check endpoint is typically the first endpoint created in enterprise APIs and is used extensively by DevOps and Operations teams.
