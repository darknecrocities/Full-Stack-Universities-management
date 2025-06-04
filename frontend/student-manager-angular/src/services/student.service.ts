import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

export interface Student {
  id?: number;
  fullName: string;
  email: string;
}

@Injectable({ providedIn: 'root' })
export class StudentService {
  private apiUrl = 'https://localhost:5001/api/student';

  constructor(private http: HttpClient) {}

  getStudents() {
    return this.http.get<Student[]>(this.apiUrl);
  }

  addStudent(student: Student) {
    return this.http.post(this.apiUrl, student);
  }

  deleteStudent(id: number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}
