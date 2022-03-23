# Overview

Read a group of files, parse data into models / DB, display orders on webUI, and implement search functionality. 

**Using**: .netcore3.1, MVC, SQLite, EF

___
### Next steps...
- parse app_data into models
  - abstract for additional file types
  - create if exists check
  - run on application startup

#### then... 
- rebuild CRUD for new view model setup
- refine search if not exists

- create unit tests

___
## Starting
- One solution 
- Two projects (main + test)

## Requirements:
- .netcore 3.1 MVC
- Read pipe-separated txt files in app_data
- x Display orders in web-ui
- x Search functionality (expand to CRUD)
- x Proper models (data normalization)
- Everything in control (layer between web and domain)
- Unit tests
- Error handling

## Notes:
- Any database or storage
- Abstraction (i.e. database csv => xml => database)

---
### Validations

**Files**
- blank rows
- name already imported

**Models**