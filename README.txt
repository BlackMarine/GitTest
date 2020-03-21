소스트리를 이용한 협업 
================

참조:
Git을 이용하여 텔레파시 통하는 팀 만들기: commit message와 commit log 숙지하기!
	http://story.haezoom.com/?p=936
Git의 동작 원리 [Git으로 시작하는 협업과 오픈소스 프로젝트 4강]
	https://ndb796.tistory.com/187?category=1029186

Summary:
ENH: (Enhancement) 개선하거나 신기능 추가
BUG: 버그 수정
DOC: (Documentation) 문서화 관련된 작업
TST: (Test) 새로운 유닛테스트를 추가하거나 기존 테스트를 수정
BLD: (Build) 빌드 프로세스 관련 코드 혹은 스크립트를 수정
PERF: (Performance) 계산 속도의 개선과 관련된 작업
CLN: (Cleanup) 코드를 정리하거나 리팩토링한 작업

주의사항:
1. merge 커밋을 만들지 않는다.
2. 커밋알림을 킨다.
3. Feedback을 한다!

Ex)
BLD: MainController.cs 추가
DOC: README 추가
CLN, DOC: 불필요한 부분 삭제 및 주석 추가