using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Repository.Models;
using Repository.Repository;

namespace CD_Management_System
{
    public partial class Form1 : Form
    {
        AlbumRepository _albumRepository = new AlbumRepository();
        SongRepository _songRepository = new SongRepository();
        public Form1()
        {
            InitializeComponent();

            var albumList = _albumRepository.GetAll()
                .Select(p => new
                {
                    p.AlbumId,
                    p.AlbumName,
                    p.ReleaseYear,
                    p.Author,
                    p.AlbumGenre,
                    p.Price,
                    p.Quantity
                }).ToList();

            dgvAlbumList.DataSource = new BindingSource()
            {
                DataSource = albumList
            };
        }

        private void getSongList(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvAlbumList[0, e.RowIndex].Value;
            var temp = _albumRepository.GetAll().Where(p => p.AlbumId.Equals(id)).FirstOrDefault();
            if (temp != null)
            {
                intAlbumID.Text = temp.AlbumId.ToString();
                txtAlbumName.Text = temp.AlbumName;
                intReleaseYear.Text = temp.ReleaseYear.ToString();
                txtAuthor.Text = temp.Author;
                txtAlbumGerne.Text = temp.AlbumGenre;
                dblPrice.Text = temp.Price.ToString();
                intQuantity.Text = temp.Quantity.ToString();
                txtDescription.Text = temp.Description;
            }
            var listAlbum = _albumRepository.GetAll()
                .Select(p => new { p.AlbumId, p.AlbumName })
                .ToList();
            var songList = _songRepository.GetAll().Where(p => p.AlbumId.Equals(id))
                .Include(p => p.Album)
                .Select(p => new
                {
                    p.SongId,
                    p.SongName,
                    p.Duration,
                    p.Album.AlbumName
                }).ToList();

            dgvSongList.DataSource = new BindingSource()
            {
                DataSource = songList
            };
        }

        private void operation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string op = button.Text;

            switch (op)
            {
                case "Create":
                    int id = Int32.Parse(intAlbumID.Text);
                    if (_albumRepository.GetAll().Where(p => p.AlbumId.Equals(id)).FirstOrDefault() != null)
                    {
                        createSong(_albumRepository.GetAll().Where(p => p.AlbumId.Equals(id)).FirstOrDefault());
                    }
                    else
                    {
                        createAlbum();
                        createSong(createAlbum());

                    }
                    reload();
                    break;
                case "Update":

                    break;
                case "Delete":
                    deleteSong();
                    clearForm();
                    reload();
                    break;
                case "Cancel":
                    clearForm();
                    break;
                default:
                    MessageBox.Show("Something's wrong, try again", "System message", MessageBoxButtons.OK);
                    break;
            }
        }

        private Cdalbum createAlbum()
        {
            var cdAlbum = new Cdalbum();
            cdAlbum.AlbumName = txtAlbumName.Text;
            cdAlbum.ReleaseYear = Int32.Parse(intReleaseYear.Text);
            cdAlbum.Author = txtAuthor.Text;
            cdAlbum.AlbumGenre = txtAlbumGerne.Text;
            cdAlbum.Price = Double.Parse(dblPrice.Text);
            cdAlbum.Quantity = Int32.Parse(intQuantity.Text);
            cdAlbum.Description = txtDescription.Text;
            _albumRepository.Create(cdAlbum);
            return cdAlbum;
        }

        private void createSong(Cdalbum album)
        {
            var song = new Song();
            song.AlbumId = album.AlbumId;
            song.SongName = txtSongName.Text;
            song.Duration = txtDuration.Text;
            _songRepository.Create(song);

        }

        public void reload()
        {
            var albumList = _albumRepository.GetAll()
                .Select(p => new
                {
                    p.AlbumId,
                    p.AlbumName,
                    p.ReleaseYear,
                    p.Author,
                    p.AlbumGenre,
                    p.Price,
                    p.Quantity
                }).ToList();

            dgvAlbumList.DataSource = new BindingSource()
            {
                DataSource = albumList
            };
            var listAlbum = _albumRepository.GetAll()
                .Select(p => new { p.AlbumId, p.AlbumName })
                .ToList();
            var songList = _songRepository.GetAll().Where(p => p.AlbumId.Equals(Int32.Parse(intAlbumID.Text)))
                .Include(p => p.Album)
                .Select(p => new
                {
                    p.SongId,
                    p.SongName,
                    p.Duration,
                    p.Album.AlbumName
                }).ToList();

            dgvSongList.DataSource = new BindingSource()
            {
                DataSource = songList
            };
        }

        public void deleteSong()
        {
            var id = Int32.Parse(intSongID.Text);
            var selectedSong = _songRepository.GetAll()
                .Where(p => p.SongId.Equals(id)).FirstOrDefault();
            _songRepository.Delete(selectedSong);
        }

        private void chooseSong(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvSongList[0, e.RowIndex].Value;
            var selectedSong = _songRepository.GetAll()
                .Where(p => p.SongId.Equals(id))
                .FirstOrDefault();
            if (selectedSong != null)
            {
                intSongID.Text = selectedSong.SongId.ToString();
                txtSongName.Text = selectedSong.SongName;
                txtDuration.Text = selectedSong.Duration;
            }
        }

        private void clearForm()
        {
            txtAlbumGerne.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtSongName.Text = string.Empty;
            txtAlbumName.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtDescription.Text = string.Empty;
            intAlbumID.Text = string.Empty;
            intQuantity.Text = string.Empty;
            intSongID.Text = string.Empty;
            intReleaseYear.Text = string.Empty;
            dblPrice.Text = string.Empty;
        }
    }
}