# Write your MySQL query statement below


WITH StudentSubject AS (
    SELECT * FROM
    Students CROSS JOIN Subjects
    ORDER BY student_id, subject_name
),
NumofExams AS (
    SELECT student_id, subject_name, COUNT(*) cnt
    FROM Examinations
    GROUP BY student_id, subject_name
)

SELECT StudentSubject.student_id, student_name, StudentSubject.subject_name,
CASE WHEN cnt IS NULL THEN 0 ELSE cnt END attended_exams
FROM StudentSubject LEFT JOIN NumofExams
ON StudentSubject.student_id = NumofExams.student_id AND StudentSubject.subject_name = NumofExams.subject_name
ORDER BY StudentSubject.student_id, StudentSubject.subject_name