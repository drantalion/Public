##############################################################################
#   Project name: Capgemini Technical Test - Employees and Departments APP   #
#   Name: Dragos                                                             #
#   Surname: Dumitrascu                                                      #
#   Date created: 06.06.2022                                                 #
##############################################################################
import pickle


class Employee():
    def __init__(self, fname, lname, age, job, salary, bonus, totalsalary, department):
        self.fname = fname
        self.lname = lname
        self.age = age
        self.job = job
        self.salary = salary
        self.bonus = bonus
        self.totalsalary = totalsalary
        self.department = department

    def set_fname(self, fname):
        self.fname = fname
    def set_lname(self,lname):
        self.lname = lname
    def set_age(self, age):
        self.age = age
    def set_job(self, job):
        self.job = job
    def set_salary(self, salary):
        self.salary = salary
    def set_bonus(self,bonus):
        self.bonus = bonus
    def set_department(self, department):
        self.department = department

    def get_fname(self):
        return self.fname
    def get_lname(self):
        return self.lname
    def get_age(self):
        return self.age
    def get_job(self):
        return self.job
    def get_salary(self):
        return self.salary
    def get_bonus(self):
        return self.bonus
    def get_department(self):
        return self.department
    
    def __str__(self):
        return "First Name: "+self.fname+ "Last Name: "+self.lname+ "Age: "+self.age+ "Job: "+self.job+ "Salary: "+self.salary+ "Bonus: "+self.bonus+ "Department: "+self.department


def load_employee():
    try:
        with open('employee.dat', 'rb') as load_dictionary:
            employee_details = pickle.load(load_dictionary)
        load_dictionary.close()
    except IOError:
        employee_details = {}
    return employee_details
    

def save_employee(employee_dictionary):
    with open('employee.dat','wb') as save_file:
        pickle.dump(employee_dictionary, save_file)
    save_file.close()


def search_employee(employee_dictionary):
    search = input("Enter your search query: (CTRL + Z to stop the querry')'")
    search_result = employee_dictionary.get(search, "Entry not found!")
    print(search_result)


def add_employee(employee_dictionary):
    again = 'y'
    while again.lower() == 'y':
        _fname = input("Enter First Name: ")
        _lname = input("Enter Last Name: ")
        _age = input("Enter Age: ")
        _job = input("Enter Job Title: ")
        _salary = input("Enter Salary: ")
        _bonus = input("Enter Bonus: ")
        _department = input("Enter Department: ")
        if _fname not in employee_dictionary:
            entry = Employee(_fname,_lname,_age,_job,_salary,_bonus, _salary+_bonus,_department)
            employee_dictionary[_fname] = entry
            print(_fname, "has been successfully added.")
        else:
            print(_fname, "already exists!")
    again = input("Enter 'y' to continue or any other key to quit.")


def change_employee(employee_dictionary):
    search = input("Enter the name of the Employee you wish to change the details: (CTRL + Z to stop the querry')'")
    if search in employee_dictionary:
        _fname = input("Enter new First Name: ")
        _lname = input("Enter new Last Name: ")
        _age = input("Enter new Age: ")
        _job = input("Enter new Job Title: ")
        _salary = input("Enter new Salary: ")
        _bonus = input("Enter new Bonus: ")
        _department = input("Enter new Department: ")
        entry = Employee(_fname,_lname,_age,_job,_salary,_bonus, _salary+_bonus, _department)
        employee_dictionary[_fname] = entry
        print(_fname, "has been successfully updated.")
    else:
        print("Entry not found!")


def delete_employee(employee_dictionary):
    search = input("Enter the name of the you wish to remove: ")
    if search in employee_dictionary:
        del employee_dictionary[search]
        print(search, "has been deleted successfully.")
    else:
        print("Entry not found!")


def menu():
    print("\nChoose your Option below:\n")
    print("\tLook-up Employee : 1")
    print("\tAdd new Employee : 2")
    print("\tChange an existing Employee : 3")
    print("\tDelete an Employee : 4")
    print("\tQuit the program : 5")

def user_interface():
    print("""
    ------------------------------------------------------------------------
    ===== Welcome to your personal Company Employee Management System! =====
    ------------------------------------------------------------------------
    """)
    employee_dictionary = load_employee()
    menu()
    choice = int(input("Enter your choice: "))
    while choice >=1 or choice >5:
        if(choice == 1):
            search_employee(employee_dictionary)
        elif(choice == 2):
            add_employee(employee_dictionary)
        elif(choice == 3):
            change_employee(employee_dictionary)
        elif(choice == 4):
            delete_employee(employee_dictionary)
        elif(choice == 5):
            exit("The program would quit now...")
    save_employee(employee_dictionary)


user_interface()        