#  Contract Monthly Claim System (CMCS)

## 📖 Overview

The **Contract Monthly Claim System (CMCS)** is a prototype ASP.NET Core MVC web application designed to streamline the submission, review, and approval of Independent Contractor (IC) lecturer monthly claims.

The system allows:

* **Lecturers** → Submit claims, upload supporting documents, and track claim status.
* **Programme Coordinators** → Review submitted claims and approve/reject them.
* **Academic Managers** → Perform final approvals and maintain oversight of processed claims.

This prototype was developed as part of the **PROG6212 POE PART1**. It currently focuses on design, usability, and workflow representation rather than full production-level functionality.



## ⚙️ Features

* **Lecturer Dashboard**

  * Submit claim form with Hours Worked, Hourly Rate, Faculty, Module, and Sessions
  * Upload supporting documents (PDF, images)
  * Auto-calculated total amount
  * Track claim status

* **Coordinator Dashboard**

  * View list of lecturer claims
  * Approve/Reject claims
  * Add review notes

* **Manager Dashboard**

  * Review claims approved by coordinators
  * Final approval functionality
  * Oversight of claim history

* **Track Claim**

  * Lecturers can track the progress of their claims across statuses: Pending, Approved, Rejected, Finalized

* **Clean and Consistent UI**

  * Bootstrap-based responsive layout
  * Custom CSS theme (purple–aqua gradient styling)
  * Easy navigation with **Home, Submit Claim, Track Claim, Coordinator Review, Manager Approval**



## 🗄️ Database Design

The system design is based on five entities:

1. **Lecturer** → stores lecturer details
2. **Claim** → records lecturer-submitted claims
3. **ClaimStatus** → tracks current claim state
4. **SupportingDocuments** → stores uploaded evidence
5. **Approval** → logs actions from coordinators and managers


## 🖥️ GUI Design

* **Navigation bar** with consistent theme across pages
* **Submit Claim Form** with validation and auto-calculation
* **Data tables** (Coordinator & Manager dashboards) styled to match the theme
* **Track Claim Page** displaying claim status history



## 📜 Documentation

The `Documentation` folder includes:

* **Report (PDF)**
* **Full Documentation(Docx)**


##  Credits

* Developed by: *Eden Gwenda ST10452860*
* Module: **PROG6212 – Programming 2B**
