<jsp:include page="./CommandJSPImport/Header.jsp"/>
        <div class="container">

            <header>

				<nav class="codrops-demos">

				</nav>
            </header>
            <section>				
                <div id="container_demo" >
                    <!-- hidden anchor to stop jump http://www.css3create.com/Astuce-Empecher-le-scroll-avec-l-utilisation-de-target#wrap4  -->
                    <a class="hiddenanchor" id="toregister"></a>
                    <a class="hiddenanchor" id="tologin"></a>
                    <div id="wrapper">
                        

                        <div id="login" class="animate form">
                            <form  action="mysuperscript.php" autocomplete="on"> 
                                <h1>> Creation d'un compte gestionnaire </h1>
                                <p> 
                                    <label for="emailsignup" class="youmail" data-icon="e" > Votre email</label>
                                    <input id="emailsignup" name="emailsignup" required="required" type="email" placeholder="ex: mysupermail@mail.com"/>
                                </p>
                                <p>
                                    <label for="usernamesignup" class="uname" data-icon="u">Nom de la coopérative</label>
                                    <input id="usernamesignup" name="usernamesignup" required="required" type="text" placeholder="ex: NomCoop" />
                                </p>
                                <p>
                                    <label for="usernamesignup" class="uname" data-icon="u">Adresse de la coopérative</label>
                                    <input id="usernamesignup" name="usernamesignup" required="required" type="text" placeholder="ex: 541 rue Dubois" />
                                </p>
                                <p> 
                                    <label for="passwordsignup" class="youpasswd" data-icon="p">Votre mot de passe</label>
                                    <input id="passwordsignup" name="passwordsignup" required="required" type="password" placeholder="ex: X8df!90EO"/>
                                </p>
                                <p> 
                                    <label for="passwordsignup_confirm" class="youpasswd" data-icon="p">Confirmez Votre mot de passe</label>
                                    <input id="passwordsignup_confirm" name="passwordsignup_confirm" required="required" type="password" placeholder="ex: X8df!90EO"/>
                                </p>
                                <p class="signin button"> 
									<input type="submit" value="S'inscrire"/>
								</p>
                                <p class="change_link">  
									Déja un membre ?
									<a href= "/GestionnaireDeLivre/Login" class="to_register"> Se connecter </a>
								</p>
                            </form>
                        </div>
						
                    </div>
                </div>  
            </section>
        </div>
        
        
        <!-- Pour gagner de l'espace -->
<table>
    <tr>
        <th height="200px"> </th>
    </tr>
</table>
        <!-- Fin pour gagner de l'espace -->
        
        
<jsp:include page="./CommandJSPImport/Footer.jsp"/>