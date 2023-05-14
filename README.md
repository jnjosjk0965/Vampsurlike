# 무기 구현용
- 김동헌
- ㅇㅇ


------
# 자주쓰는 코드
   
## 조준탄
			d = Math.abs(ppx() - sizeX / 2 - this.x) >= Math.abs(ppy() - sizeY / 2 - this.y)    
					? Math.abs(ppx() - sizeX / 2 - this.x)   
					: Math.abs(ppy() - sizeY / 2 - this.y);   
   
			vx = (ppx() - sizeX / 2 - x) * speed / d;   
			vy = (ppy() - sizeY / 2 - y) * speed / d;   

  
## 회전탄 (vxvy-회전점 이동 속도, cxcy-회전점, r-반경, vr-반경 변화값, theta-각도, omega-실행 당 회전 이동값)
			this.theta += this.omega;

			// 각도 변화
			this.r += vr;

			x = (cx + r * Math.cos(theta));
			y = (cy + r * Math.sin(theta));
			cx += vx;
			cy += vy;

//			vx = -r * omega * Math.sin(theta);
//			vy = r * omega * Math.cos(theta);


