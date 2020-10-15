namespace WebStory.Models
{
    /// <summary>
    /// Defines the <see cref="TheoDoi" />.
    /// </summary>
    public class TheoDoi
    {
        /// <summary>
        /// Defines the idTheodoi.
        /// </summary>
        private int idTheodoi;

        /// <summary>
        /// Defines the idUser.
        /// </summary>
        private int idUser;

        /// <summary>
        /// Defines the idFollower.
        /// </summary>
        private int idFollower;

        /// <summary>
        /// Initializes a new instance of the <see cref="TheoDoi"/> class.
        /// </summary>
        public TheoDoi()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TheoDoi"/> class.
        /// </summary>
        /// <param name="idTheodoi">The idTheodoi<see cref="int"/>.</param>
        /// <param name="idUser">The idUser<see cref="int"/>.</param>
        /// <param name="idFollower">The idFollower<see cref="int"/>.</param>
        public TheoDoi(int idTheodoi, int idUser, int idFollower)
        {
            this.idTheodoi = idTheodoi;
            this.idUser = idUser;
            this.idFollower = idFollower;
        }

        /// <summary>
        /// The getIdTheodoi.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdTheodoi()
        {
            return idTheodoi;
        }

        /// <summary>
        /// The setIdTheodoi.
        /// </summary>
        /// <param name="idTheodoi">The idTheodoi<see cref="int"/>.</param>
        public void setIdTheodoi(int idTheodoi)
        {
            this.idTheodoi = idTheodoi;
        }

        /// <summary>
        /// The getIdUser.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdUser()
        {
            return idUser;
        }

        /// <summary>
        /// The setIdUser.
        /// </summary>
        /// <param name="idUser">The idUser<see cref="int"/>.</param>
        public void setIdUser(int idUser)
        {
            this.idUser = idUser;
        }

        /// <summary>
        /// The getIdFollower.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public int getIdFollower()
        {
            return idFollower;
        }

        /// <summary>
        /// The setIdFollower.
        /// </summary>
        /// <param name="idFollower">The idFollower<see cref="int"/>.</param>
        public void setIdFollower(int idFollower)
        {
            this.idFollower = idFollower;
        }
    }
}
